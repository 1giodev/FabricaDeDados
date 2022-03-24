import { Endereco } from './endereco';
import { Telefone } from './Telefone';
export class Pessoa {
    Nome: string;
    Cpf: string;
    Rg: string;
    Cnh: string;
    TItuloEleitor: string;
    PisPasep: string;
    DataNascimento: string;
    Idade: number;
    Sexo: string;
    NomeMae: string;
    NomePai: string;
    Email: string;
    Endereco: Endereco;
    Telefone: Telefone[];
    Altura: number;
    Peso: number;
    TipoSanguineo: string;
}