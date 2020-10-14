export interface Devs {
    complete: Dev[];
    tiny: SmallDev[]
}

export interface Dev {
    firstname: string;
    lastname: string;
    innovation: string;
    year: string;
}

export interface SmallDev {
    name: string;
    invented: string;
    year: string;
}