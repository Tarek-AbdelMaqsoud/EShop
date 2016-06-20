var EShopAPP = angular.module('EShopAPP', ['ngRoute']);

EShopAPP.controller('mainController', function ($scope, $http) {
    $http.get('http://localhost:53385/api/products/getall').
      success(function (data, status, headers, config) {
          $scope.products = data;
      }).
      error(function (data, status, headers, config) {
          alert("error");
      });
    $scope.AddToCart = function (index) {
        var data = $scope.products;
        var product = data[index];
        $http.post('http://localhost:54566/Products/AddToCart?ProductID=' + product.ProductID).
            success(function (data, status, headers, config) {
                if (data == 'true') {
                    window.location = "/";
                }
                else {
                    alert('Invalid Data');
                }
            }).
            error(function (data, status, headers, config) {
                alert("error");
            });
    };
});




//EShopAPP.controller('mainController', ['$scope', '$http', function ($scope, $http) {
//    $scope.submit = function () {
//        if ($scope.Name) {
//            var product = {
//                "Name": $scope.Name,
//                "Description": $scope.Description,
//                "Price": $scope.Price,
//                "Count": $scope.Count
//            }
//            $http.post('http://localhost:53385/api/products/AddToCart', product).
//            success(function (data, status, headers, config) {
//                if (data == 'true') {
//                    window.location = "/";
//                }
//                else {
//                    alert('Invalid Data');
//                }
//            }).
//            error(function (data, status, headers, config) {
//                alert("erro");
//            });
//        }
//    };
//}]);