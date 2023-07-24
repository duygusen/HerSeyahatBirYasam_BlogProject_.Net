// Tüm akordiyon düğmelerini seçin
var accordions = document.getElementsByClassName('accordion');

// Her bir akordiyon düğmesi için tıklama olayını tanımlayın
for (var i = 0; i < accordions.length; i++) {
  accordions[i].addEventListener('click', function() {
    // İçerik panelini alın (sonraki kardeş)
    var panel = this.nextElementSibling;

    // Panel görünürse gizleyin, aksi halde gösterin
    if (panel.style.display === 'block') {
      panel.style.display = 'none';
    } else {
      panel.style.display = 'block';
    }
  });
}