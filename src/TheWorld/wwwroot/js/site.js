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
    $("#sidebarToggle").on("click", function ()
    {
        sidebarAndWrapper.toggleClass("hide-sidebar");
        if (sidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        }
        else {
            $(this).text("Hide Sidebar");
        }
    })
})();