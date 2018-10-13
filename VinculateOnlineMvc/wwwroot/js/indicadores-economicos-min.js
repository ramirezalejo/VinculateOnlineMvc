
valIndicadoresMin=document.getElementById('IndicadoresMin');
if (valIndicadoresMin)
	{
	var valCode = 'no';
	if (!valIndicadoresMin.links)
		{
		valIndicadoresMin.links = valIndicadoresMin.getElementsByTagName('a');
		}
	for (var t=0; t<valIndicadoresMin.links.length; t++)
		{
		var valProv = valIndicadoresMin.links[t];
		
		if (valProv.href.search('http://dolar.wilkinsonpc.com.co/') != -1 || valProv.href.search('https://dolar.wilkinsonpc.com.co/') != -1) {
			if(valProv.getAttribute('rel') == 'nofollow')
				{
				} else {
				valCode='si'; break;
				} 
			} 
		}
	}

if(valIndicadoresMin&&valCode=='si')
{
while(valIndicadoresMin.firstChild){valIndicadoresMin.removeChild(valIndicadoresMin.firstChild)};
valIndicadoresMin.style.cssText='background:transparent;background-color:transparent;overflow:hidden;';
marko=document.write('<iframe SRC="https://dolar.wilkinsonpc.com.co/widgets/gratis/indicadores-economicos-min.html?ancho=190&alto=105&fondo=transparent&fsize=13&ffamily=sans-serif&fcolor=000000&custom=si" id="IEDolar" style="width:190px;height:105px;" title="Dolar" width="190" height="105" ALIGN="top" frameborder="0" marginwidth=0 marginheight=0 SCROLLING=no name="IE-1" allowtransparency="true"></iframe>');
marko=document.createElement('font');
marko.id='check';
valIndicadoresMin.appendChild(marko);
}
else {
alert("ERROR: INDICADORES ECONOMICOS\n------------------------------------------------------------------------\nEl codigo introducido no es correcto\nVerifica tu codigo en: https://dolar.wilkinsonpc.com.co/indicadores-economicos-dolar.html\n\n* Recuerda que no se permite editar el codigo.\n\n- Copialo tal cual como aparece en nuestro sitio web.\n- Actualiza tu codigo por el mas reciente.");
}
