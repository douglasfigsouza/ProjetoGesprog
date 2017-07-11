app.controller("GesprogCtrl", function ($scope, GesprogService) {
    getAllStates();
    // função que busca todos os estados 
    function getAllStates() {
        var servCall = GesprogService.getEstates();
        servCall.then(function (d) {
            $scope.lstStates = d;
            console.log(d);
        }, function (error) {
            alert("Opss! Não foi possivel buscar os Estados");
        });
    }
});