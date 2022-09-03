let listaBtnModelo = document.getElementsByClassName('itemListaModelos');

let listaImgModelo = document.getElementsByClassName('imgModelo');
console.log(listaBtnModelo);
console.log(listaImgModelo);

for (let i = 0; i < listaBtnModelo.length; i++) {
    let elementoImagem = listaImgModelo[i];
    let elementoBtn = listaBtnModelo[i];

    elementoBtn.onclick = function () {
        resetaEstado();
        elementoImagem.classList.add("fade-in");
        elementoImagem.classList.remove("hidden");
        elementoBtn.classList.add("activeBtnModelo");
    };



}

function resetaEstado() {
    for (let i = 0; i < listaImgModelo.length; i++) {
        let elementoImagem = listaImgModelo[i];
        let elementoBtn = listaBtnModelo[i];
        elementoImagem.classList.remove("fade-in");
        elementoBtn.classList.remove("activeBtnModelo");
        elementoImagem.classList.add("hidden");

        
    }
}