document.getElementById('menu-button').addEventListener('click', function () {
  var menuIcon = document.getElementById('menu-icon');
  
  if (menuIcon.classList.contains('flip')) {
    menuIcon.classList.remove('flip');
  } else {
    menuIcon.classList.add('flip');
  }
});







