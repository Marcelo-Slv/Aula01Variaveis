# Aula01Variaveis

##Teste de edição

---

### Manual de uso de arquivos `.md` (Markdown)

## Identificação

| Campo  | Preencha aqui |
|--------|---------------|
| **Nome:**   | _(Marcelo Expedito)_ |
| **Matéria:** | _(DS)_ |
| **Data:**    | _(12/08/2026)_ |

---

## O que é Markdown?

Markdown é uma linguagem de marcação simples usada para formatar texto. Arquivos `.md`
são amplamente usados em documentação de projetos (ex.: `README.md` no GitHub).

---

## Formatações principais

### 1. Títulos

Use `#` para títulos. Quantos mais `#`, menor o nível do título.

```
# Título nível 1
## Título nível 2
### Título nível 3
```

### 2. Texto em negrito e itálico

```
**negrito**
*itálico*
***negrito e itálico***
```

**negrito**
*itálico*
***negrito e itálico***

### 3. Listas

```
- Item 1
- Item 2
  - Subitem

1. Primeiro
2. Segundo
```

- Item 1
- Item 2
  - Subitem

1. Primeiro
2. Segundo

### 4. Links

```
[Texto do link](https://exemplo.com)
```

[Texto do link](https://exemplo.com)

### 5. Imagens e GIFs

```
![Descrição da imagem](caminho/da/imagem.png)
![Descrição do gif](caminho/do/gif.gif)
```

Exemplo de GIF:

![Gato digitando](https://media.giphy.com/media/JIX9t2j0ZTN9S/giphy.gif)

### 6. Código

```
Para código em linha use crase: `código`
```

Para código em bloco, use três crases:

```python
x = 10
print("Olá, mundo!")
```

### 7. Tabelas

```
| Nome  | Idade | Cidade |
|-------|-------|--------|
| João  | 25    | SP     |
| Maria | 30    | RJ     |
```

| Nome  | Idade | Cidade |
|-------|-------|--------|
| João  | 25    | SP     |
| Maria | 30    | RJ     |

### 8. Citações

```
> Isto é uma citação.
```

> Isto é uma citação.

### 9. Lista de tarefas

```
- [x] Tarefa concluída
- [ ] Tarefa pendente
```

- [x] Tarefa concluída
- [ ] Tarefa pendente

---

## Desenho (ASCII Art)

Markdown aceita desenhos feitos com caracteres, basta colocá-los dentro de um bloco de código:

```
     ____________________
    |                    |
    |   MEU DESENHO      |
    |   ____             |
    |  /    \   /\       |
    | |  ^^  | <  >      |
    |  \____/   \/       |
    |  __|  |__          |
    |____________________|
```

```
     __      __
    |  \    /  |
    |   \  /   |
    |    \/    |
    |   /\/\   |
    |  /    \  |
    | /      \ |
    |/        \|
```

---

## Dica

Salve o arquivo com a extensão `.md` (ex.: `README.md`) e abra em qualquer visualizador
de Markdown (GitHub, VS Code com preview, Typora, etc.) para ver a formatação renderizada.
