
// the widget service is "constructor injected" into the controller

function WidgetCtrl($scope, widgetSvc, $rootScope) {
    $scope.widgets = new Array();

    $scope.sendWidget = function() {
        widgetSvc.sendRequest();
    };

    var addWidget = function(data) {
        $scope.widgets.push(data);
    };

    widgetSvc.initialize();

    $scope.$parent.$on("newWidget", function (e, data) {
        $scope.$apply(function () {
            addWidget(data);
        });
    });
}