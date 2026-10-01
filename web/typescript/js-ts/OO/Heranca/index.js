import { Animal } from './Animal.js';
import { Cachorro } from './Cachorro.js';
import { Cobra } from './Cobra.js';

const animal = new Animal("Animal", "Raca", 10, 5);
const cachorro = new Cachorro("Cachorro", "Raca", 10, 5, "Preto");
const cobra = new Cobra("Cobra", "Raca", 10, 5, "Vermelha");

console.log(cobra);