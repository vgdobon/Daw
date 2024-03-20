let texto = document.getElementById("texto");
let salida = document.getElementById("salida");

function corregirTexto(){
    let textoSinCorregir = texto.value;
    

    textoSinCorregir = corregirPuntuacion(textoSinCorregir,",");
    textoSinCorregir = corregirPuntuacion(textoSinCorregir,".");

    salida.innerText = textoSinCorregir;
}

function corregirPuntuacion(texto,puntuacion){
    let indiceActual=0;
    let longitud = texto.length;

    while(indiceActual<longitud){
        indiceActual = texto.indexOf(puntuacion,indiceActual);
        if(indiceActual==-1){
            break;
        }
        if(texto.charAt(indiceActual+1)!=" "){
            texto = texto.substring(0,indiceActual+1) + " " +  texto.slice(indiceActual+1,longitud+1);
        }
        indiceActual+=1;
        longitud = texto.length;
    }

    return texto;
}

function corregirTextoGPT() {
    // Obtén el valor del textarea
    let textoOriginal = document.getElementById('texto').value; // Reemplaza 'miTextarea' con el ID real de tu textarea
  
    // Agrega un espacio después de cada punto o coma si no lo tiene
    let textoCorregido = textoOriginal.replace(/([.,])(?!\s)/g, '$1 ');
  
    // Actualiza el valor del textarea con el texto corregido
    document.getElementById('texto').value = textoCorregido; // Reemplaza 'miTextarea' con el ID real de tu textarea
  }
