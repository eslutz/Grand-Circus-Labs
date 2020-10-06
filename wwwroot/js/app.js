//Tallest Mountian
function findNameOfTallestMountian(mountians) {
    var tallestMountian = undefined;
    if (!(mountians === undefined || mountians.length == 0)) {
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
//# sourceMappingURL=app.js.map