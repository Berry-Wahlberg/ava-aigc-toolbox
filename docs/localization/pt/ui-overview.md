# Visão Geral da Interface

> **A versão em português é a oficial**

A AVA AIGC Toolbox apresenta uma interface intuitiva e bem organizada, projetada para ajudá-lo a gerenciar suas imagens geradas por IA de forma eficiente. Este guia fornece uma explicação detalhada de todos os principais componentes da interface.

## Layout da Janela Principal

A janela do aplicativo é dividida em cinco seções principais:

1. **Barra de Menu** - Navegação de nível superior e comandos do aplicativo
2. **Barra Lateral** - Acesso rápido a diferentes visualizações e filtros
3. **Barra de Ferramentas** - Ações comuns e configurações
4. **Área de Conteúdo Principal** - Exibição e detalhes das imagens
5. **Barra de Status** - Status e informações do aplicativo

```
┌─────────────────────────────────────────────────────────────────┐
│                        Barra de Menu                           │
├─────────────────────────────────────────────────────────────────┤
│                        Barra de Ferramentas                     │
├───────────────┬─────────────────────────────────────────────────┤
│               │                                                 │
│  Barra Lateral│              Área de Conteúdo Principal         │
│               │                                                 │
├───────────────┴─────────────────────────────────────────────────┤
│                        Barra de Status                          │
└─────────────────────────────────────────────────────────────────┘
```

## 1. Barra de Menu

A barra de menu contém comandos e configurações do aplicativo completo, organizados nos seguintes menus:

### Menu Arquivo
- **Nova Biblioteca**: Cria uma nova biblioteca de imagens vazia
- **Abrir Biblioteca**: Abre um banco de dados de biblioteca existente
- **Importar**: 
  - **Importar Imagens**: Importa imagens de pastas
  - **Importar Metadados**: Importa metadados de arquivos
- **Exportar**: 
  - **Exportar Imagens Selecionadas**: Exporta imagens selecionadas para uma pasta
  - **Exportar Todas as Imagens**: Exporta todas as imagens na visualização atual
- **Configurações**: Abre as configurações do aplicativo
- **Sair**: Fecha o aplicativo

### Menu Editar
- **Desfazer**: Desfaz a última ação
- **Refazer**: Refaz a última ação desfeita
- **Selecionar Tudo**: Seleciona todas as imagens na visualização atual
- **Desselecionar Tudo**: Desseleciona todas as imagens selecionadas
- **Inverter Seleção**: Inverte a seleção atual
- **Procurar**: Abre o diálogo de pesquisa

### Menu Visualizar
- **Alternar Barra Lateral**: Mostra ou oculta a barra lateral
- **Alternar Painel de Detalhes**: Mostra ou oculta o painel de detalhes
- **Modo de Visualização**: 
  - **Visualização em Grade**: Exibe imagens em uma grade
  - **Visualização em Lista**: Exibe imagens em uma lista com detalhes
- **Ordenar Por**: Altera a ordem de classificação das imagens
- **Zoom**: Ajusta o nível de zoom da grade de imagens
- **Atualizar**: Atualiza a visualização atual

### Menu Ferramentas
- **Operações em Lote**: 
  - **Renomear em Lote**: Renomeia várias imagens de uma vez
  - **Adicionar Tags em Lote**: Adiciona tags a várias imagens
  - **Exportar em Lote**: Exporta várias imagens com configurações personalizadas
- **Editor de Metadados**: Abre ferramentas avançadas de edição de metadados
- **Ferramentas de Imagem**: 
  - **Recortar**: Recorta imagens
  - **Redimensionar**: Redimensiona imagens
  - **Converter Formato**: Converte imagens para diferentes formatos
- **Ferramentas de IA**: 
  - **Auto-Etiquetar**: Usa IA para etiquetar automaticamente imagens
  - **Gerar Miniaturas**: Regenera miniaturas para todas as imagens

### Menu Ajuda
- **Documentação**: Abre esta documentação
- **Atalhos do Teclado**: Exibe atalhos do teclado
- **Sobre**: Mostra a versão do aplicativo e créditos
- **Verificar Atualizações**: Verifica se há novas versões
- **Relatar Problema**: Abre a página de problemas do GitHub

## 2. Barra Lateral

A barra lateral fornece acesso rápido a diferentes visualizações e recursos organizacionais:

### Visualização de Pastas
- **Pastas Raiz**: Exibe as pastas raiz que você adicionou à sua biblioteca
- **Subpastas**: Expanda pastas para visualizar seu conteúdo
- **Adicionar Pasta**: Clique no botão `+` para adicionar uma nova pasta raiz
- **Opções de Pasta**: Clique com o botão direito em uma pasta para acessar opções como:
  - Atualizar Pasta
  - Remover Pasta
  - Propriedades

### Visualização de Álbuns
- **Meus Álbuns**: Exibe todos os álbuns criados pelo usuário
- **Adicionar Álbum**: Clique no botão `+` para criar um novo álbum
- **Opções de Álbum**: Clique com o botão direito em um álbum para acessar opções como:
  - Renomear Álbum
  - Excluir Álbum
  - Adicionar Imagens
  - Propriedades

### Visualização de Tags
- **Todas as Tags**: Exibe todas as tags na sua biblioteca, classificadas por uso
- **Nuvem de Tags**: Representação visual das tags por popularidade
- **Adicionar Tag**: Clique no botão `+` para criar uma nova tag
- **Opções de Tag**: Clique com o botão direito em uma tag para acessar opções como:
  - Renomear Tag
  - Excluir Tag
  - Mesclar Tags
  - Visualizar Imagens com Tag

### Coleções Inteligentes
- **Todas as Imagens**: Todas as imagens na sua biblioteca
- **Favoritos**: Imagens marcadas como favoritas
- **Recentemente Adicionadas**: Imagens adicionadas nos últimos 30 dias
- **Recentemente Visualizadas**: Imagens visualizadas nos últimos 7 dias
- **Imagens Sem Tags**: Imagens sem qualquer tag
- **Para Exclusão**: Imagens marcadas para exclusão

## 3. Barra de Ferramentas

A barra de ferramentas fornece acesso rápido a ações comuns e configurações:

### Barra de Ferramentas Principal
- **Importar**: Importa imagens de pastas
- **Atualizar**: Atualiza a visualização atual
- **Modo de Visualização**: Alterna entre visualizações em grade e lista
- **Ordenar**: Altera a ordem de classificação (por nome, data, tamanho, etc.)
- **Filtrar**: Abre o painel de filtro
- **Configurações**: Abre as configurações do aplicativo

### Barra de Ferramentas de Operações com Imagens
- **Favorito**: Marca/desmarca imagens selecionadas como favoritas
- **Excluir**: Exclui imagens selecionadas
- **Tag**: Adiciona tags a imagens selecionadas
- **Editar**: Abre o editor de imagens
- **Exportar**: Exporta imagens selecionadas

## 4. Área de Conteúdo Principal

A área de conteúdo principal exibe imagens e seus detalhes, e consiste em duas partes:

### Exibição de Imagens

#### Visualização em Grade
- **Miniaturas de Imagem**: Exibe imagens em uma grade de miniaturas
- **Seleção**: 
  - Clique para selecionar uma única imagem
  - Ctrl/Cmd + Clique para selecionar várias imagens
  - Shift + Clique para selecionar uma faixa de imagens
  - Arraste para selecionar várias imagens em uma área retangular
- **Informações da Imagem**: Mostra informações básicas ao pairar (nome do arquivo, dimensões, tamanho)

#### Visualização em Lista
- **Colunas**: Exibe imagens com colunas para:
  - Nome do arquivo
  - Tamanho
  - Dimensões
  - Data de Adição
  - Data de Modificação
  - Classificação
  - Status de Favorito
- **Classificação**: Clique nos cabeçalhos das colunas para classificar por essa coluna
- **Colunas Redimensionáveis**: Arraste os divisores das colunas para ajustar as larguras

#### Visualização em Tela Cheia
- **Clique Duplo**: Abre uma imagem em visualização em tela cheia
- **Navegação**: 
  - Teclas de seta para navegar entre imagens
  - Escape para sair do modo de tela cheia
  - Clique com o botão direito para opções adicionais
- **Zoom**: Use a roda do mouse para ampliar/reduzir
- **Pan**: Clique e arraste para mover quando ampliado

### Painel de Detalhes

O painel de detalhes aparece no lado direito da janela quando uma imagem é selecionada, exibindo informações detalhadas sobre a imagem:

#### Informações Básicas
- **Nome do arquivo**: Nome do arquivo de imagem
- **Caminho**: Caminho completo do arquivo
- **Tamanho**: Tamanho do arquivo em bytes/KB/MB
- **Dimensões**: Largura e altura em pixels
- **Resolução**: Informação de DPI (se disponível)
- **Formato**: Formato do arquivo (JPEG, PNG, etc.)
- **Data de Adição**: Quando a imagem foi adicionada à biblioteca
- **Data de Modificação**: Última data de modificação do arquivo

#### Metadados de IA
- **Prompt**: O prompt usado para gerar a imagem
- **Prompt Negativo**: O prompt negativo usado
- **Etapas**: Número de etapas de geração
- **Amostrador**: Nome do amostrador usado
- **Escala CFG**: Valor da escala CFG
- **Seed**: Valor da seed usada para geração
- **Modelo**: Nome do modelo usado
- **Hash do Modelo**: Hash do modelo
- **Largura/Altura**: Dimensões geradas

#### Propriedades da Imagem
- **Classificação**: Sistema de classificação de 1-5 estrelas
- **Favorito**: Alterna o status de favorito
- **Para Exclusão**: Marca para exclusão
- **NSFW**: Marca como Não Seguro para o Trabalho
- **Indisponível**: Arquivo está indisponível

#### Tags
- **Lista de Tags**: Exibe todas as tags associadas à imagem
- **Adicionar Tag**: Clique em `+` para adicionar novas tags
- **Remover Tag**: Clique em `×` para remover tags existentes

## 5. Barra de Status

A barra de status aparece na parte inferior da janela e exibe:

- **Total de Imagens**: Número de imagens na visualização atual
- **Imagens Selecionadas**: Número de imagens selecionadas
- **Status do Filtro**: Filtro atual sendo aplicado
- **Status da Classificação**: Critério atual de classificação
- **Status do Aplicativo**: Atividade atual do aplicativo (importando, exportando, etc.)
- **Tamanho do Banco de Dados**: Tamanho do banco de dados atual

## 6. Diálogos e Painéis

### Diálogo de Importação
- **Seleção de Pasta**: Escolha pastas para importar imagens
- **Opções de Importação**: 
  - Incluir subpastas
  - Sobrescrever imagens existentes
  - Extrair metadados
  - Gerar miniaturas
- **Indicador de Progresso**: Mostra o progresso da importação

### Diálogo de Exportação
- **Pasta de Destino**: Escolha onde exportar as imagens
- **Opções de Exportação**: 
  - Incluir metadados
  - Redimensionar imagens
  - Converter para formato
  - Renomear arquivos
- **Indicador de Progresso**: Mostra o progresso da exportação

### Painel de Filtro
- **Pesquisa de Texto**: Pesquise por nome do arquivo, tags ou metadados
- **Intervalo de Datas**: Filtre por data de criação ou modificação
- **Dimensões**: Filtre por largura e altura da imagem
- **Classificação**: Filtre por classificação de estrelas
- **Tags**: Filtre por tags específicas
- **Metadados de IA**: Filtre por modelo, amostrador, etapas, etc.

### Diálogo de Configurações
- **Geral**: Idioma do aplicativo, tema e opções de inicialização
- **Biblioteca**: Localização do banco de dados e configurações de backup
- **Importar**: Opções padrão de importação
- **Exibir**: Tamanho das miniaturas, espaçamento da grade e opções de visualização
- **Metadados**: Opções de extração e exibição de metadados
- **Atalhos do Teclado**: Personalize atalhos do teclado

## 7. Menus de Contexto

Menus de contexto aparecem quando você clica com o botão direito em vários elementos:

### Menu de Contexto da Imagem
- **Visualizar**: Abre em visualização em tela cheia
- **Editar**: Edita imagem ou metadados
- **Copiar**: Copia imagem para a área de transferência
- **Mover Para**: Move imagem para outra pasta ou álbum
- **Copiar Para**: Copia imagem para outro local
- **Excluir**: Exclui imagem da biblioteca
- **Adicionar ao Álbum**: Adiciona a álbum existente
- **Adicionar Tags**: Adiciona tags à imagem
- **Remover Tags**: Remove tags da imagem
- **Definir Classificação**: Define a classificação de estrelas
- **Marcar como Favorito**: Alterna o status de favorito
- **Propriedades**: Visualiza propriedades detalhadas

### Menu de Contexto da Pasta
- **Abrir no Explorer/Finder**: Abre a pasta no gerenciador de arquivos do sistema
- **Atualizar**: Atualiza o conteúdo da pasta
- **Remover Pasta**: Remove da biblioteca (não exclui arquivos)
- **Propriedades**: Visualiza propriedades da pasta

### Menu de Contexto do Álbum
- **Abrir**: Visualiza o conteúdo do álbum
- **Renomear**: Renomeia o álbum
- **Excluir**: Exclui o álbum
- **Adicionar Imagens**: Adiciona imagens ao álbum
- **Remover Imagens**: Remove imagens selecionadas do álbum
- **Propriedades**: Visualiza propriedades do álbum

### Menu de Contexto da Tag
- **Visualizar Imagens**: Visualiza todas as imagens com esta tag
- **Renomear**: Renomeia a tag
- **Excluir**: Exclui a tag
- **Mesclar Com**: Mescla com outra tag
- **Propriedades**: Visualiza propriedades da tag

## 8. Atalhos do Teclado

Para acesso rápido a comandos comuns, consulte a referência [Atalhos do Teclado](./keyboard-shortcuts.md).

## Opções de Personalização

### Tema
- **Modo Claro**: Esquema de cores brilhante
- **Modo Escuro**: Esquema de cores escuro
- **Tema do Sistema**: Segue as configurações de tema do sistema

### Opções de Visualização
- **Tamanho das Miniaturas**: Ajusta o tamanho das miniaturas na visualização em grade
- **Espaçamento da Grade**: Ajusta o espaçamento entre imagens na visualização em grade
- **Mostrar/Ocultar Colunas**: Personaliza quais colunas aparecem na visualização em lista
- **Posição do Painel de Detalhes**: Move o painel de detalhes para a esquerda ou direita

### Tamanho da Fonte
- Ajusta o tamanho da fonte para melhor legibilidade

## Dicas para Navegação Eficiente

1. **Navegação pelo Teclado**: Use atalhos do teclado para operação mais rápida
2. **Personalize a Barra de Ferramentas**: Adicione comandos frequentemente usados à barra de ferramentas
3. **Fixe Itens Frequentes**: Fixe pastas, álbuns e tags frequentemente usados no topo de suas respectivas listas
4. **Use Coleções Inteligentes**: Aproveite as coleções inteligentes pré-criadas para acesso rápido
5. **Filtros Personalizados**: Crie e salve filtros personalizados para pesquisas recorrentes
6. **Foco do Teclado**: Pressione `Tab` para navegar entre elementos da interface
7. **Menus de Contexto**: Clique com o botão direito em elementos para acesso rápido a opções

## Conclusão

A interface da AVA AIGC Toolbox é projetada para ser intuitiva e eficiente, com todos os recursos facilmente acessíveis da interface principal. Ao se familiarizar com os diferentes componentes, você será capaz de navegar e usar o aplicativo de maneira mais eficaz, ajudando você a gerenciar suas imagens geradas por IA com facilidade.

Para mais informações sobre recursos específicos, consulte as seções relevantes nesta documentação: