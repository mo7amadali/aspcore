(function startup() {
    
    //var ele = $("#username");

    //ele.text("Mohamed Ali");

    //var main = $("#main");
    //main.on("mouseenter", function () {
    //    main.style = "color: red;";        
    //});

    //main.on("mouseleave", function () {
    //    main.style="";
    //});
    //var menuItems = $(".menu li a");
    //menuItems.on("click", function () {
    //    alert($(this).text());
    //});
    var sidebarAndWrapper = $("#sidebar,#wrapper");
    var icon = $("#sidebarToggle i.fa");
    $("#sidebarToggle").on("click", function ()
    {
        sidebarAndWrapper.toggleClass("hide-sidebar");
        if (sidebarAndWrapper.hasClass("hide-sidebar")) {
            icon.addClass("fa-angle-right");
            icon.removeClass("fa-angle-left");
            
        }
        else {
            icon.addClass("fa-angle-left");
            icon.removeClass("fa-angle-right");
        }
    })
})();