function atributos(patributo) {

    if (patributo.value != "") {
        // console.log(patributo.id)
        var atributos = ["padrao_forca", "padrao_destreza", "padrao_constituicao", "padrao_inteligencia", "padrao_sabedoria", "padrao_carisma"];
        var valor = document.getElementById(patributo.id).value;
        // console.log(valor);
        for (i = 0; i < atributos.length; i++) {
            if (atributos[i] != patributo.id) {

                var option = document.getElementById(atributos[i] + valor);
                option.disabled = 'disabled';

            }
            else {


                var consulta = localStorage.getItem(patributo.id);
                if (consulta !== null) {
                    console.log(consulta);
                    for (j = 0; j < atributos.length; j++) {
                        var option = document.getElementById(atributos[j] + consulta);
                        option.disabled = false;
                    }


                }
                var local = localStorage.setItem(patributo.id, valor);

            }
        }

    }



}

function flushLocal() {
    var atributos = ["Forca", "Destreza", "Constituicao", "Inteligencia", "Sabedoria", "Carisma"];
    for (i = 0; i < atributos.length; i++) {
        localStorage.removeItem(atributos[i]);

    }
}

function escolher(id) {
    if (id.id == "radio_distpadrao") {
        document.getElementById('div_distpadrao').style.visibility = "visible";
        document.getElementById('div_distpadrao').style.display = "block";
        document.getElementById('div_distrolar').style.visibility = "hidden";
        document.getElementById('div_distrolar').style.display = "none";
    } else {
        document.getElementById('div_distpadrao').style.visibility = "hidden";
        document.getElementById('div_distpadrao').style.display = "none";
        document.getElementById('div_distrolar').style.visibility = "visible";
        document.getElementById('div_distrolar').style.display = "block";
        flushLocal();
    }
}

function rolar(id) {
    var rolar;
    let rolados = [];
    var resultado = 0;
    for (i = 0; i < 4; i++) {
        rolar = Math.floor(Math.random() * 6) + 1;
        rolados.push(rolar)
    }
    var retirar = Math.min(...rolados);
    for (i = 0; i < rolados.length; i++) {
        resultado += rolados[i];
    }
    resultado -= retirar;
    if (resultado < 6 || resultado > 20) {
        rolar(id);
    }
    if(id.id == "roladorforca"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }
    // if(id.id == "roladorf"){
    //     document.getElementsByClassName(id.id + "orca")[0].setAttribute('value', Number(resultado));
    // }
    if(id.id == "roladordestreza"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }
    if(id.id == "roladorconstituicao"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }  
    if(id.id == "roladorinteligencia"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }
    if(id.id == "roladorsabedoria"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }
    if(id.id == "roladorcarisma"){
        document.getElementsByClassName(id.id)[0].setAttribute('value', Number(resultado));
    }}
    