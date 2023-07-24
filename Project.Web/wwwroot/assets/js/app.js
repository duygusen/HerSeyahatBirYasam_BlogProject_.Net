let bookList =[] ,
 basketList = [] ;

toastr.options = {
    closeButton: false,
    debug: false,
    newestOnTop: false,
    progressBar: false,
    positionClass: "toast-bottom-right",
    preventDuplicates: false,
    onclick: null,
    showDuration: "300",
    hideDuration: "1000",
    timeOut: "5000",
    extendedTimeOut: "1000",
    showEasing: "swing",
    hideEasing: "linear",
    showMethod: "fadeIn",
    hideMethod: "fadeOut",
};

const toogleModal = () => {
    const basketModalEl = document.querySelector(".basket__modal");
    basketModalEl.classList.toggle("active");
};

const getBooks = () => {
    fetch("/assets/products.json").then((res) => res.json()).then((books) => (bookList = books));
};

getBooks();

const createBookStars = (starRate) => {
    let starRateHTML ="";
    for(let i=1; i<=5; i++){
        if(Math.round(starRate) >=i)
        starRateHTML += `<i class="bi bi-star-fill active"></i>`;
        else starRateHTML += `<i class="bi bi-star-fill"></i>`;
    }

    return starRateHTML;
}

const createBookItemsHTML = () => {
    const bookListEl = document.querySelector(".book__list");
    let bookListHTML = "";
    bookList.forEach((book, index) =>{
        bookListHTML += `<div class="col-5 ${index % 2 == 0} m-5" > 
        <div class="row book__card">
          <div class="col-6">
            <img class="img-fluid shadow" src="${book.imgSource}" width="258" height="400" alt="">
          </div>

          <div class="col-6 d-flex flex-column justify-content-between">
            <div class="book__detail">
              <span class="fs-4 fw-bold">${book.name}</span>
              <span class="fos gray fs-5">${book.seller}</span>
              <div>
                  <span class="book__star-rate">
                    ${createBookStars(book.starRate)}
                    <span class="gray">${book.reviewCount} reviews</span>
                  </span>
              </div>
            </div>
            <p class="book__description fos gray">${book.description}</p>
            <div>
            <span class="black fw-bold fs-4 me-2">${book.price}₺</span>
            ${book.oldPrice ? `<span class="fs-4 fw-bold old__price">${book.oldPrice}₺</span>` : ""}
            </div>
            <button class="btn__purple" onclick="addBookToBasket(${book.id})">SEPETE EKLE</button>
          </div>

        </div>
      </div>`
    });

    bookListEl.innerHTML = bookListHTML;
};

const BOOK_TYPES ={
    ALL: "Tümü",
};


const createBookTypesHTML = () => {
    const filterEl = document.querySelector(".filter");
    let filterHTML ="";
    let filterTypes = ["Tümü"];
    bookList.forEach((book) => {
        if (filterTypes.findIndex((filter) => filter == book.type) == -1)
        filterTypes.push(book.type);
    });

    filterTypes.forEach((type, index) =>{
        filterHTML += `<li class="${index== 0 ? "active" : null}" onclick="filterBooks(this)" data-type="${type}">${
            type
        } </li>`;
    }); 

    filterEl.innerHTML = filterHTML;
};

const filterBooks = (filterEl) => {
    document.querySelector(".filter .active").classList.remove("active");
    filterEl.classList.add("active");
    let bookType = filterEl.dataset.type;
    getBooks();
    if(bookType != "ALL")
        bookList = bookList.filter((book) => book.type == bookType);
    createBookItemsHTML();
};

const listBasketItems = () => {
    localStorage.setItem("basketList",JSON.stringify(basketList));
    const basketListEl = document.querySelector(".basket__list");
    const basketCountEl = document.querySelector(".basket__count");
    basketCountEl.innerHTML = basketList.length > 0 ? basketList.length : null;
    const totalPriceEl = document.querySelector(".total__price");

    let basketListHTML = "";
    let totalPrice = 0;
    basketList.forEach((item) => {
        totalPrice += item.product.price * item.quantity;
        basketListHTML += `<li class="basket__item">
        <img src="${item.product.imgSource}" width="100" height="100" alt="">
        <div class="basket__item-info">
        <h3 class="book__name">${item.product.name}</h3>
        <span class="book__price">${item.product.price} ₺</span><br/>
        <span class="book__remove" onclick="removeItemToBasket(${item.product.id})">Sil</span>
        </div>
        <div class="book__count">
        <span class="decrease" onclick="decreaseItemToBasket(${item.product.id})">-</span>
        <span class="my-5">${item.quantity}</span>
        <span class="increase" onclick="increaseItemToBasket(${item.product.id})">+</span>
        </div>
    </li>`;
    });

    basketListEl.innerHTML = basketListHTML ? basketListHTML : `<li class="basket__item">Sepette Ürün Yok</li>`;
    totalPriceEl.innerHTML = 
        totalPrice > 0 ? + totalPrice.toFixed(2) + "₺" : null;

};

const addBookToBasket = (bookId) => {
    let findedBook = bookList.find((book) => book.id == bookId);
    if(findedBook){
        const basketAlreadyIndex = basketList.findIndex(
            (basket) => basket.product.id == bookId
        );
        if (basketAlreadyIndex == -1){
            let addedItem = { quantity: 1, product: findedBook};
            basketList.push(addedItem);
        } else{
            if( 
                basketList[basketAlreadyIndex].quantity <
                basketList[basketAlreadyIndex].product.stock
            )
            basketList[basketAlreadyIndex].quantity += 1;
            else {
            toastr.error( "Üründe yeterli stok bulunmamaktadır.");
            return;
        
             }
        }
        listBasketItems();
        toastr.success( "Ürün başarılı şekilde sepete eklendi.")
    }
};

const removeItemToBasket = (bookId) => {
    const findedIndex = basketList.findIndex(
        (basket) => basket.product.id == bookId
    );
    if (findedIndex != -1){
        basketList.splice(findedIndex, 1);
    }
    listBasketItems();
};

const decreaseItemToBasket = (bookId) => {
    const findedIndex = basketList.findIndex(
        (basket) => basket.product.id == bookId
    );
    if (findedIndex != -1){
        if(basketList[findedIndex].quantity != 1)
        basketList[findedIndex].quantity -= 1;
        else removeItemToBasket(bookId);
        listBasketItems();
    }
};

const increaseItemToBasket = (bookId) => {
    const findedIndex = basketList.findIndex(
        (basket) => basket.product.id == bookId
    );
    if (findedIndex != -1){
        if(basketList[findedIndex].quantity <  basketList[findedIndex].product.stock)
        basketList[findedIndex].quantity += 1;
        else toastr.error( "Üründe yeterli stok bulunmamaktadır.");
        listBasketItems();
    }
};

if(localStorage.getItem("basketList")){
    basketList = JSON.parse(localStorage.getItem("basketList"));
    listBasketItems();
};

document.addEventListener('DOMContentLoaded', function() {
    var odemeEkraniBtn = document.getElementById('odemeEkraniBtn');
  
    odemeEkraniBtn.addEventListener('click', function() {
      window.location.href = 'checkout';
    });
});

setTimeout(() => {
    getBooks();
    createBookItemsHTML();
    createBookTypesHTML();
},100);