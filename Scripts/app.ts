//Tallest Mountian
interface Mountian {
	name: String,
	height: number
}

function findNameOfTallestMountian(mountians: Mountian[]) {
	let tallestMountian = undefined;
	if (!(mountians === undefined || mountians === null || mountians.length == 0)) {
		tallestMountian = mountians[0];
		for (let mountian of mountians) {
			if (mountian.height > tallestMountian.height) {
				tallestMountian = mountian;
			}
		}
	}
	return tallestMountian.name
}

function getTallestMountian() {
	let mountians: Mountian[] = [
		{ name: "Kilimanjaro", height: 19341 },
		{ name: "Everest", height: 29029 },
		{ name: "Denali", height: 20310 }
	];
	let tallestMountianName = findNameOfTallestMountian(mountians);
	console.log(tallestMountianName);
}

//Products
interface Product {
	name: String,
	price: number
}

function calcAverageProductPrice(products: Product[]) {
	let averageProductPrice = 0;
	if (!(products === undefined || products === null ||products.length == 0)) {
		for (let product of products) {
			averageProductPrice += product.price;
		}
		averageProductPrice = averageProductPrice / products.length;
	}
	return `$${averageProductPrice.toFixed(2)}`;
}

function getAveragePrice() {
	let products: Product[] = [
		{ name: "Pizza", price: 8.99 },
		{ name: "Soda", price: 1.59 },
		{ name: "Hot Dog", price: 3.79 },
		{ name: "Hamburger", price: 5.99 }
	];
	let averagePrice = calcAverageProductPrice(products);
	console.log(averagePrice);
}

//Inventory
interface Inventory {
	product: Product,
	quantity: number
}

function calcInventoryValue(inventory: Inventory[]) {
	let totalValue = 0;
	if (!(inventory === undefined || inventory === null || inventory.length == 0)) {
		for (let product of inventory) {
			totalValue += product.product.price * product.quantity;
		}
	}
	return `$${totalValue.toFixed(2)}`;
}

function getTotalValue() {
	let inventory: Inventory[] = [
		{ product: { name: "motor", price: 10.00 }, quantity: 10 },
		{ product: { name: "sensor", price: 12.50 }, quantity: 4 },
		{ product: { name: "LED", price: 1.00 }, quantity: 20 }
	];
	let totalValue = calcInventoryValue(inventory);
	console.log(totalValue);
}