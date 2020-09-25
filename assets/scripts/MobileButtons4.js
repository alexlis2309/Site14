window.onload = function () {
  var list = document.getElementById('list2');
  var cur = document.getElementById('div2').children[0];

  function sh(cur, next) {
    cur.style.display = 'none';
    next.style.display = 'block';
  }

  document.body.onclick = function (e) {
    e = e || event;
    var target = e.target || e.srcElement;
    var elem;
    if (target.className == 'previous2') {
      if (target.parentNode.previousSibling.previousSibling) { //previousElementSibling
        elem = target.parentNode.previousSibling.previousSibling;
        sh(cur, elem);
        cur = elem;
      }
    } else
    if (target.className == 'next2') {
      if (cur.nextSibling.nextSibling) { //nextElementSibling
        elem = cur.nextSibling.nextSibling;
        sh(cur, elem);
        cur = elem;
      }
    } else
    if (target.parentNode.parentNode.id == 'list2') {
      elem = document.getElementById(target.getAttribute('href').replace('#', ''));
      sh(cur, elem);
      cur = elem;
    }
  }
}