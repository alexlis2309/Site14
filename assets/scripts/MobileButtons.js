window.onload = function () {
  var list = document.getElementById('list');
  var cur = document.getElementById('div').children[0];

  var list2 = document.getElementById('list2');
  var cur2 = document.getElementById('div2').children[0];

  var list3 = document.getElementById('list3');
  var cur3 = document.getElementById('div3').children[0];

  function sh(cur, next) {
    cur.style.display = 'none';
    next.style.display = 'block';
  }

  function sh2(cur2, next2) {
    cur2.style.display = 'none';
    next2.style.display = 'block';
  }

  function sh3(cur3, next3) {
    cur3.style.display = 'none';
    next3.style.display = 'block';
  }

  document.body.onclick = function (e) {
    e = e || event;
    var target = e.target || e.srcElement;
    var elem;
    if (target.className == 'previous') {
      if (target.parentNode.previousSibling.previousSibling) { //previousElementSibling
        elem = target.parentNode.previousSibling.previousSibling;
        sh(cur, elem);
        cur = elem;
      }
    } else
    if (target.className == 'next') {
      if (cur.nextSibling.nextSibling) { //nextElementSibling
        elem = cur.nextSibling.nextSibling;
        sh(cur, elem);
        cur = elem;
      }
    } else
    if (target.parentNode.parentNode.id == 'list') {
      elem = document.getElementById(target.getAttribute('href').replace('#', ''));
      sh(cur, elem);
      cur = elem;
    }

    e = e || event;
    var target2 = e.target || e.srcElement;
    var elem2;

    if (target2.className == 'previous2') {
      if (target2.parentNode.previousSibling.previousSibling) { //previousElementSibling
        elem2 = target.parentNode.previousSibling.previousSibling;
        sh2(cur2, elem2);
        cur2 = elem2;
      }
    } else
    if (target2.className == 'next2') {
      if (cur2.nextSibling.nextSibling) { //nextElementSibling
        elem2 = cur2.nextSibling.nextSibling;
        sh2(cur2, elem2);
        cur2 = elem2;
      }
    } else
    if (target2.parentNode.parentNode.id == 'list2') {
      elem2 = document.getElementById(target2.getAttribute('href').replace('#', ''));
      sh2(cur2, elem2);
      cur2 = elem2;
    }



    e = e || event;
    var target3 = e.target || e.srcElement;
    var elem3;

    if (target3.className == 'previous3') {
      if (target3.parentNode.previousSibling.previousSibling) { //previousElementSibling
        elem3 = target.parentNode.previousSibling.previousSibling;
        sh3(cur3, elem3);
        cur3 = elem3;
      }
    } else
    if (target3.className == 'next3') {
      if (cur3.nextSibling.nextSibling) { //nextElementSibling
        elem3 = cur3.nextSibling.nextSibling;
        sh3(cur3, elem3);
        cur3 = elem3;
      }
    } else
    if (target3.parentNode.parentNode.id == 'list3') {
      elem3 = document.getElementById(target3.getAttribute('href').replace('#', ''));
      sh3(cur3, elem3);
      cur3 = elem3;
    }




  }
}