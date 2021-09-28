function findNameOfTallestMountian(mountians) {
    var tallestMountian = undefined;
    if (!(mountians === undefined || mountians === null || mountians.length == 0)) {
        tallestMountian = mountians[0];
        for (var _i = 0, mountians_1 = mountians; _i < mountians_1.length; _i++) {
            var mountian = mountians_1[_i];
            if (mountian.height > tallestMountian.height) {
                tallestMountian = mountian;
            }
        }
    }
    return tallestMountian.name;
}
function getTallestMountian() {
    var mountians = [
        { name: "Kilimanjaro", height: 19341 },
        { name: "Everest", height: 29029 },
        { name: "Denali", height: 20310 }
    ];
    var tallestMountianName = findNameOfTallestMountian(mountians);
    console.log(tallestMountianName);
}
function calcAverageProductPrice(products) {
    var averageProductPrice = 0;
    if (!(products === undefined || products === null || products.length == 0)) {
        for (var _i = 0, products_1 = products; _i < products_1.length; _i++) {
            var product = products_1[_i];
            averageProductPrice += product.price;
        }
        averageProductPrice = averageProductPrice / products.length;
    }
    return "$" + averageProductPrice.toFixed(2);
}
function getAveragePrice() {
    var products = [
        { name: "Pizza", price: 8.99 },
        { name: "Soda", price: 1.59 },
        { name: "Hot Dog", price: 3.79 },
        { name: "Hamburger", price: 5.99 }
    ];
    var averagePrice = calcAverageProductPrice(products);
    console.log(averagePrice);
}
function calcInventoryValue(inventory) {
    var totalValue = 0;
    if (!(inventory === undefined || inventory === null || inventory.length == 0)) {
        for (var _i = 0, inventory_1 = inventory; _i < inventory_1.length; _i++) {
            var product = inventory_1[_i];
            totalValue += product.product.price * product.quantity;
        }
    }
    return "$" + totalValue.toFixed(2);
}
function getTotalValue() {
    var inventory = [
        { product: { name: "motor", price: 10.00 }, quantity: 10 },
        { product: { name: "sensor", price: 12.50 }, quantity: 4 },
        { product: { name: "LED", price: 1.00 }, quantity: 20 }
    ];
    var totalValue = calcInventoryValue(inventory);
    console.log(totalValue);
}
//# sourceMappingURL=app.js.map