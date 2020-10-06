//Tallest Mountian
interface Mountian {
	name: String,
	height: Number
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
	return `$${averageProductPrice}`;
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