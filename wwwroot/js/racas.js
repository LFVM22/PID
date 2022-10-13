function racas() {
  //Atribui à uma variável/lista todos os elementos que apresentem o atributo 'name' sendo 'raca'
  var radio = document.getElementsByName('IdRaca');
  //Desmarca qualquer opção, dentro dos formulários de descrição das raças e subraças, que por ventura esteja marcada
  for (let element of document.getElementsByClassName("subracas")) {
    element.checked = false;
  }
  //Realiza um loop através de todos os radiobox da variável 'radio'
  for (i = 0; i < radio.length; i++) {
    //Checa se a radiobox com o id 'anao' está checada
    if (document.getElementById('1').checked == true) {
      //Realiza um loop por todos os elementos cuja classe seja 'subracas', removendo sua visibility e seu display
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      //Atribui visibilidade e display ao furmulário cujo 'id' é 'anaosubracas'
      document.getElementById("Anãosubracas").style.visibility = "visible";
      document.getElementById("Anãosubracas").style.display = "block";
    }
    else if (document.getElementById('2').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Elfosubracas").style.visibility = "visible";
      document.getElementById("Elfosubracas").style.display = "block";
    }
    else if (document.getElementById('3').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Halflingsubracas").style.visibility = "visible";
      document.getElementById("Halflingsubracas").style.display = "block";
    }
    else if (document.getElementById('4').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Humanosubracas").style.visibility = "visible";
      document.getElementById("Humanosubracas").style.display = "block";

    }
    else if (document.getElementById('5').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Draconatosubracas").style.visibility = "visible";
      document.getElementById("Draconatosubracas").style.display = "block";
    }
    else if (document.getElementById('6').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Gnomosubracas").style.visibility = "visible";
      document.getElementById("Gnomosubracas").style.display = "block";
    }
    else if (document.getElementById('7').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Meio-Elfosubracas").style.visibility = "visible";
      document.getElementById("Meio-Elfosubracas").style.display = "block";
    }
    else if (document.getElementById('8').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Meio-Orcsubracas").style.visibility = "visible";
      document.getElementById("Meio-Orcsubracas").style.display = "block";
    }
    else if (document.getElementById('9').checked == true) {
      for (let element of document.getElementsByClassName("subracas")) {
        element.style.visibility = "hidden";
        element.style.display = "none";
      }
      document.getElementById("Tieflingsubracas").style.visibility = "visible";
      document.getElementById("Tieflingsubracas").style.display = "block";
    }
  }
}
