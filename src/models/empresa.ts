import { Endereco } from "./endereco";
import { Telefone } from "./Telefone";

export class Empresa {
    RazaoSocial: string;
    Cnpj: string;
    InscricaoEstadual: string;
    DataAbertura: Date;
    WebSite: string;
    Email: string;
    Endereco: Endereco;
    Telefone: Telefone[];
}