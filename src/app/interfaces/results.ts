export interface Source {
    kind: string;
    data: Results
}

export interface Results {
    modhash: string;
    dist: number;
    children: Children[];
}

export interface Children {
    kind: string;
    data: Result;
}

export interface Result {
    title: string;
    thumbnail: string;
    permalink: string;
}