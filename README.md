# blazor-viacep-net

Aula de Blazor WebAssembly — Desenvolvimento Web (Prof. Daniel Henrique Matos de Paiva).

Aplicação **Blazor WebAssembly Standalone** (.NET 10) que consulta endereços pelo CEP usando a
API pública [ViaCEP](https://viacep.com.br).

## Funcionalidades

- Campo para digitar o CEP (aceita `01001000` ou `01001-000`) e consultar com o botão ou Enter.
- Validação: CEP vazio ou com quantidade de dígitos diferente de 8 exibe mensagem de erro.
- Exibe CEP, Logradouro, Complemento, Bairro, Localidade, UF e DDD em uma tabela.
- CEP inexistente ou falha de conexão exibem alerta na tela.

## Estrutura

| Arquivo                          | Responsabilidade                                        |
|----------------------------------|---------------------------------------------------------|
| `BlazorViaCep/Models/Endereco.cs`| Classe de modelo que representa o JSON do ViaCEP        |
| `BlazorViaCep/Pages/Home.razor`  | Formulário, validação, chamada à API e exibição         |

## Como rodar

Requer .NET SDK 10.0.

```bash
cd BlazorViaCep
dotnet watch run
```

Acesse `http://localhost:5172` e teste com o CEP `01001000` (Praça da Sé, São Paulo).
