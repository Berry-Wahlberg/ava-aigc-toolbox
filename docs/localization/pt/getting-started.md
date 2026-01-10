# Guia de Primeiros Passos

> **A versão em português é a oficial**

## Bem-vindo à AVA AIGC Toolbox

Obrigado por escolher a AVA AIGC Toolbox! Este guia irá ajudá-lo a começar com o aplicativo e explorar seus recursos principais.

## Primeiro Lançamento

### 1. Iniciar o Aplicativo
- **Windows**: Clique duas vezes no atalho da área de trabalho ou use o menu Iniciar
- **macOS**: Abra da pasta Aplicativos ou use o Spotlight
- **Linux**: Inicie do menu de aplicativos ou execute `ava-aigc-toolbox` no terminal

### 2. Configuração Inicial

Quando você inicia o aplicativo pela primeira vez:

1. **Tela de Boas-Vindas**
   - Você verá uma tela de boas-vindas com opções para:
     - Começar com uma biblioteca vazia
     - Importar imagens existentes
     - Saber mais sobre o aplicativo

2. **Escolha Sua Opção**
   - **Começar com uma biblioteca vazia**: Cria um novo banco de dados para suas imagens
   - **Importar imagens existentes**: Permite que você selecione pastas para importar imagens
   - **Saber mais**: Abre a documentação

3. **Localização do Banco de Dados**
   - O aplicativo cria automaticamente um arquivo de banco de dados:
     - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

## Navegação Básica

A janela principal é dividida em várias seções:

### 1. Barra Lateral
- **Pastas**: Navegue por suas pastas de imagens
- **Álbuns**: Acesse seus álbuns de imagens
- **Tags**: Navegue e filtre por tags
- **Todas as Imagens**: Veja todas as imagens em sua biblioteca

### 2. Área de Conteúdo Principal
- **Grade de Imagens**: Exibe imagens em um layout de grade
- **Detalhes da Imagem**: Mostra metadados e propriedades quando uma imagem é selecionada

### 3. Barra de Ferramentas
- **Importar**: Adicione novas imagens à sua biblioteca
- **Ordenar**: Altere a ordem de classificação das imagens
- **Filtrar**: Aplique filtros à grade de imagens
- **Visualizar**: Alternar entre visualizações de grade e lista

### 4. Barra de Status
- Mostra o número total de imagens
- Exibe os critérios de filtro ou pesquisa atual
- Mostra o status do aplicativo

## Adicionando Imagens

### 1. Importando Imagens

#### Do Sistema de Arquivos
1. Clique no botão **Importar** na barra de ferramentas
2. Selecione **Importar de Pasta**
3. Escolha a pasta que contém suas imagens
4. Clique em **Selecionar Pasta** para começar a importar

#### Arrastar e Soltar
1. Abra o explorador de arquivos/finder do seu sistema
2. Selecione uma ou mais imagens
3. Arraste-as para a área de conteúdo principal do aplicativo
4. As imagens serão adicionadas à sua biblioteca

### 2. Metadados da Imagem

Quando as imagens são importadas, o aplicativo extrai automaticamente:
- Nome do arquivo e caminho
- Tamanho e dimensões do arquivo
- Datas de criação e modificação
- Metadados gerados por IA (se disponíveis):
  - Prompt
  - Prompt negativo
  - Etapas e amostrador
  - Escala CFG e seed
  - Informações do modelo

## Organizando Imagens

### 1. Usando Pastas

- O aplicativo reflete a estrutura de pastas do seu sistema de arquivos
- Navegue pelas pastas na barra lateral para visualizar imagens em locais específicos
- Novas pastas criadas no sistema de arquivos serão detectadas automaticamente

### 2. Criando Álbuns

1. Clique no botão **+** ao lado de "Álbuns" na barra lateral
2. Digite um nome para o álbum
3. Pressione Enter para criar
4. Arraste imagens da grade para o álbum para adicioná-las

### 3. Adicionando Tags

#### A Uma Única Imagem
1. Selecione uma imagem na grade
2. No painel de detalhes, encontre a seção "Tags"
3. Clique no botão **+**
4. Digite um nome para a tag e pressione Enter

#### A Múltiplas Imagens
1. Selecione várias imagens usando Ctrl/Cmd + clique
2. Clique com o botão direito e selecione **Adicionar Tags**
3. Digite nomes de tags separados por vírgulas
4. Clique em **Adicionar** para aplicar as tags a todas as imagens selecionadas

## Trabalhando com Imagens

### 1. Visualizando Imagens

- **Clique Simples**: Selecione uma imagem para ver os detalhes
- **Clique Duplo**: Abra a imagem em visualização em tela cheia
- **Clique com o Botão Direito**: Abra o menu de contexto com opções adicionais

### 2. Detalhes da Imagem

Quando uma imagem é selecionada, você verá:
- Informações básicas (nome do arquivo, tamanho, dimensões)
- Metadados da IA (prompt, prompt negativo, etc.)
- Tags associadas à imagem
- Status de classificação e favorito

### 3. Editando Metadados

1. Selecione uma imagem
2. No painel de detalhes, clique em qualquer campo editável
3. Faça suas alterações
4. Pressione Enter ou clique fora do campo para salvar

### 4. Classificação e Favoritos

- **Classificação**: Clique nas estrelas no painel de detalhes para classificar uma imagem (1-5 estrelas)
- **Favorito**: Clique no ícone do coração para marcar uma imagem como favorita
- **Para Excluir**: Marque imagens para exclusão para removê-las facilmente mais tarde

## Pesquisando e Filtrando

### 1. Pesquisa Básica

1. Digite na caixa de pesquisa no topo da janela
2. Os resultados aparecerão automaticamente à medida que você digita
3. A pesquisa corresponde a nomes de arquivos, tags e metadados

### 2. Filtragem Avançada

1. Clique no botão **Filtrar** na barra de ferramentas
2. Defina os critérios de filtro:
   - Pasta
   - Álbum
   - Tags
   - Classificação
   - Intervalo de datas
   - Dimensões
   - Metadados da IA (modelo, amostrador, etc.)
3. Clique em **Aplicar** para ver os resultados filtrados

## Exportando Imagens

### 1. Exportar uma Única Imagem

1. Selecione uma imagem
2. Clique com o botão direito e selecione **Exportar Imagem**
3. Escolha a pasta de destino
4. Clique em **Salvar**

### 2. Exportar Múltiplas Imagens

1. Selecione várias imagens
2. Clique com o botão direito e selecione **Exportar Imagens Selecionadas**
3. Escolha a pasta de destino
4. Clique em **Salvar**

### 3. Exportar com Metadados

- Ao exportar, você pode escolher incluir metadados
- Marque a opção "Incluir metadados" no diálogo de exportação
- Os metadados serão incorporados nas imagens exportadas

## Próximos Passos

Agora que você aprendeu os fundamentos, pode:

- Explorar a [Visão Geral da Interface](./ui-overview.md) para uma explicação detalhada da interface
- Aprender sobre [Gerenciamento de Imagens](./features/image-management.md) para mais detalhes sobre como gerenciar suas imagens
- Ler sobre [Organização](./features/organization.md) para aprender mais sobre pastas, álbuns e tags
- Verifique as [Perguntas Frequentes](./faq.md) para perguntas comuns

## Dicas e Truques

- **Atalhos do Teclado**: Pressione `Ctrl/Cmd + K` para ver todos os atalhos do teclado
- **Operações em Lote**: Selecione várias imagens para executar operações em lote
- **Auto-Etiquetagem**: Use a auto-etiquetagem alimentada por IA para suas imagens
- **Backup**: Faça backup regularmente do arquivo do banco de dados para evitar perda de dados
- **Atualizar Metadados**: Use o editor de metadados para manter as informações das suas imagens organizadas

Aproveite o uso da AVA AIGC Toolbox para gerenciar suas imagens geradas por IA!