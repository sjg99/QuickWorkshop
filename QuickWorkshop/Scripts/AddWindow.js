$('.iconos .cajaadd, .edit').click(function(){  
  $('.Ventana').css('display', 'block');
  $('nav, .infoBar, .contenedor-padre').css('filter', 'blur(2px)'); 
});
$('html').click(function(){
  $('.Ventana').css('display', 'none');
  $('nav, .infoBar, .contenedor-padre').css('filter', 'blur(0px)');  
});
$('.iconos .cajaadd, .VentanaAdd, .edit').click(function(e){
  e.stopPropagation();
});