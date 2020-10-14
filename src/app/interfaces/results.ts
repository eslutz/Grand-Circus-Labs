export interface Results {
    modhash: string;
    dist: number;
    children: Result[];
}

export interface Result {
    title: string;
    thumbnail: string;
    permalink: string;
}