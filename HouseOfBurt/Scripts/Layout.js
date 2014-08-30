$.asm = {};
$.asm.panels = 1;

function sidebar(panels) {
    if (panels === 1) {
        $('#content').removeClass('span9');
        $('#content').addClass('span12 no-sidebar');
        $('#sidebar').hide();
    } else if (panels === 2) {
        $('#content').removeClass('span12 no-sidebar');
        $('#content').addClass('span9');
        $('#sidebar').show();
    }
}

$('#toggleSidebar').click(function () {
    if ($.asm.panels === 1) {
        $('#toggleSidebar i').addClass('glyphicon glyphicon-chevron-left');
        $('#toggleSidebar i').removeClass('glyphicon glyphicon-chevron-right');
        return sidebar(2);
    } else {
        $('#toggleSidebar i').removeClass('glyphicon glyphicon-chevron-left');
        $('#toggleSidebar i').addClass('glyphicon glyphicon-chevron-right');
        return sidebar(1);
    }
})

function OnSearchClick() {
    var searchText = $("#txtSearch").val();
    var queryString = "SearchText=" + searchText;
    $.post("/Home/Search", queryString, callBackSearch, "_default");
}
