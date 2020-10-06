//Tallest Mountian

interface Mountian {
	name: String,
	height: Number
}

function findNameOfTallestMountian(mountians: Mountian[]) {
	let tallestMountian = undefined;
	if (!(mountians === undefined || mountians.length == 0)) {
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