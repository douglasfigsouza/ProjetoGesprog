app.service("GesprogService", function ($http) {
    // função que busca todos os estados e preeenche o combo 
    this.getEstates = function () { 
        var url = 'Programadores/getAllStates';
        return $http.get(url).then(function (response) {
            return response.data;
        });
    }
});