// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var theForm= $("#theForm")
theForm.hide();


// java script
// var theform = document.getElementById("theForm");
//
// theform.hidden=true;


//var button=document.getElementById("buyButton");

var button= $("#buyButton");


// java script
// button.addEventListener("click",function(){
//     alert("buying item");
// })

button.on("click",function () {
alert("buying item");
})

//var productInfo= document.getElementsByClassName("products-props");
var productInfo=$(".products-props li");
productInfo.on("click", function(){
    alert("product properties clicked is : " + $(this).text() )
})
// java script
//var listitems = productInfo.item[0].children();

//alert(productInfo.item(0).children.item(0).innerHTML);


var $loginToggle= $("#loginToggle")

var $popupform= $(".popup-form");

$loginToggle.on("click", function(){
  // $popupform.toggle(100);
   // $popupform.slideToggle(100);
    $popupform.fadeToggle(1000);
});