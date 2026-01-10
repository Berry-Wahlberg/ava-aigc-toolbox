# Configurações

> **A versão em português é a oficial**

A AVA AIGC Toolbox oferece um conjunto abrangente de configurações para personalizar sua experiência. Este guia cobre todas as configurações disponíveis e como configurá-las.

## Acessando as Configurações

#### Passos para Abrir as Configurações:
1. Clique no botão **Configurações** na barra de ferramentas ou vá para `Arquivo > Configurações`
2. O diálogo de configurações aparecerá
3. Use a barra lateral para navegar entre as diferentes categorias de configurações
4. Clique em **Salvar** para aplicar as alterações ou **Cancelar** para descartar as alterações
5. Algumas configurações podem exigir o reinício do aplicativo para entrar em vigor

## Configurações Gerais

### Aplicativo
- **Idioma**: Selecione o idioma do aplicativo (Português, etc.)
- **Tema**: Escolha entre tema claro, escuro ou sistema
- **Comportamento na Inicialização**: Configure o que acontece quando o aplicativo é iniciado
  - **Mostrar Tela de Boas-Vindas**: Exibir tela de boas-vindas na inicialização
  - **Abrir Última Biblioteca**: Abrir automaticamente a última biblioteca usada
  - **Minimizar para a Bandeja**: Iniciar minimizado na bandeja do sistema
- **Verificações de Atualização**: Configure verificações automáticas de atualização
  - **Verificar atualizações automaticamente**: Habilitar/desabilitar verificações automáticas de atualização
  - **Canal de atualização**: Selecione o canal de atualização (estável, beta, nightly)

### Interface
- **Tamanho da Fonte**: Ajuste o tamanho da fonte do aplicativo para melhor legibilidade
- **Tamanho dos Ícones**: Altere o tamanho dos ícones na interface
- **Animações**: Alternar animações ligadas ou desligadas
- **Dicas**: Habilitar/desabilitar dicas
- **Barra de Status**: Mostrar/ocultar a barra de status

## Configurações da Biblioteca

### Geral
- **Localização do Banco de Dados**: Caminho para o arquivo de banco de dados da biblioteca
- **Pasta de Importação Padrão**: Pasta padrão para importar imagens
- **Atualizar Biblioteca Automaticamente**: Atualizar automaticamente a biblioteca quando os arquivos mudam
- **Monitor de Arquivos**: Habilitar/desabilitar o monitoramento do sistema de arquivos

### Backup
- **Habilitar backup automático**: Habilitar/desabilitar backups agendados
- **Frequência do Backup**: Com que frequência fazer backup (diariamente, semanalmente, mensalmente)
- **Hora do Backup**: Hora do dia para executar backups
- **Tipo de Backup**: Apenas banco de dados ou backup completo
- **Pasta de Destino**: Onde armazenar backups
- **Manter Backups Por**: Por quanto tempo manter backups antigos
- **Número Máximo de Backups**: Número máximo de backups para manter

### Desempenho
- **Tamanho do Cache de Miniaturas**: Tamanho máximo do cache de miniaturas em MB
- **Tamanho do Cache de Imagens**: Tamanho máximo do cache de imagens em MB
- **Processamento Paralelo**: Número de processos paralelos para tarefas
- **Carregamento Preguiçoso**: Habilitar/desabilitar carregamento preguiçoso de imagens

## Configurações de Importação

### Geral
- **Incluir Subpastas**: Incluir subpastas durante a importação por padrão
- **Extrair Metadados**: Extrair metadados das imagens por padrão
- **Gerar Miniaturas**: Gerar miniaturas durante a importação por padrão
- **Sobrescrever Existentes**: Sobrescrever imagens existentes por padrão

### Manipulação de Arquivos
- **Ignorar Arquivos Corrompidos**: Ignorar arquivos corrompidos durante a importação
- **Ignorar Arquivos Duplicados**: Ignorar arquivos com o mesmo caminho
- **Resolução de Conflitos de Nome de Arquivo**: Como lidar com conflitos de nome de arquivo
  - **Renomear Novo Arquivo**: Renomear o novo arquivo com um sufixo
  - **Sobrescrever Existente**: Substituir o arquivo existente
  - **Ignorar**: Ignorar o novo arquivo

## Configurações de Exibição

### Visualização em Grade
- **Tamanho de Miniatura Padrão**: Tamanho padrão das miniaturas na visualização em grade
- **Espaçamento da Grade**: Espaçamento entre imagens na visualização em grade
- **Mostrar Nomes de Arquivos**: Mostrar/ocultar nomes de arquivos abaixo das miniaturas
- **Mostrar Estrelas de Classificação**: Mostrar/ocultar estrelas de classificação nas miniaturas
- **Mostrar Ícone de Favorito**: Mostrar/ocultar ícone de favorito nas miniaturas

### Visualização em Lista
- **Colunas Padrão**: Selecione quais colunas mostrar por padrão na visualização em lista
- **Larguras das Colunas**: Ajustar larguras padrão para as colunas
- **Altura das Linhas**: Definir a altura das linhas na visualização em lista

### Painel de Detalhes
- **Mostrar Painel de Detalhes**: Mostrar/ocultar o painel de detalhes por padrão
- **Posição do Painel**: Posição do painel de detalhes (esquerda, direita, inferior)
- **Seções Expandidas**: Quais seções mostrar expandidas por padrão

## Configurações de Metadados

### Extração
- **Extrair Metadados na Importação**: Extrair automaticamente metadados ao importar imagens
- **Campos de Metadados**: Selecione quais campos de metadados extrair
- **Mapeamento de Nome do Modelo**: Mapear hashes de modelos para nomes legíveis por humanos
- **Detectar Modelo Automaticamente**: Detectar automaticamente nomes de modelos a partir dos metadados

### Exibição
- **Mostrar Prompt Completo**: Mostrar prompt completo ou prompt truncado no painel de detalhes
- **Formatar Datas**: Selecionar formato de data (curto, longo, personalizado)
- **Formatar Números**: Selecionar opções de formatação de números

### Edição
- **Permitir Edição de Metadados**: Habilitar/desabilitar edição de metadados
- **Validar Metadados**: Validar metadados antes de salvar
- **Fazer Backup dos Metadados Originais**: Fazer backup dos metadados originais antes da edição

## Configurações de IA

### Geral
- **Habilitar Recursos de IA**: Alternar recursos de IA ligados ou desligados
- **Modelo de IA Padrão**: Definir o modelo de IA padrão para várias tarefas
- **Máximo de Requisições Paralelas**: Número de requisições de IA paralelas
- **Armazenar Resultados da IA em Cache**: Armazenar resultados da IA para processamento mais rápido

### Modelos de Tag
- **Modelo de Tag Padrão**: Definir o modelo padrão para auto-etiquetagem
- **Limite de Confiança das Tags**: Nível de confiança padrão para tags geradas
- **Idioma das Tags**: Idioma padrão para tags geradas

### Integração com API
- **Chave da API**: Sua chave da API para serviços de IA
- **URL da API**: URL do endpoint da API
- **Limite de Taxa**: Número máximo de requisições por minuto
- **Tempo Limite**: Tempo limite de requisição da API em segundos

## Configurações de Pesquisa

### Geral
- **Escopo de Pesquisa Padrão**: Escopo padrão para pesquisas (todas as imagens, pasta atual, etc.)
- **Tamanho do Histórico de Pesquisa**: Número de pesquisas recentes a manter
- **Auto-Completar**: Habilitar/desabilitar auto-completar de pesquisa
- **Curingas Habilitados**: Habilitar/desabilitar curingas na pesquisa

### Avançado
- **Indexação de Pesquisa**: Configurar o comportamento da indexação de pesquisa
  - **Indexar na Importação**: Indexar imagens ao importar
  - **Indexar em Segundo Plano**: Indexar imagens em segundo plano
  - **Frequência de Indexação**: Com que frequência atualizar o índice de pesquisa

## Configurações de Exportação

### Padrões
- **Formato de Exportação Padrão**: Formato padrão para exportar imagens
- **Qualidade de Exportação Padrão**: Qualidade padrão para exportação
- **Opções de Redimensionamento Padrão**: Configurações de redimensionamento padrão
- **Incluir Metadados**: Incluir metadados nas exportações por padrão

### Presets
- **Gerenciar Presets de Exportação**: Criar, editar e excluir presets de exportação
- **Preset de Exportação Padrão**: Definir o preset de exportação padrão

## Atalhos do Teclado

### Personalização
- **Habilitar Atalhos do Teclado**: Habilitar/desabilitar atalhos do teclado
- **Personalizar Atalhos**: Modificar atalhos do teclado existentes
- **Redefinir para Padrões**: Restaurar atalhos do teclado padrão

## Configurações de Resolução de Problemas

### Registro
- **Nível de Registro**: Defina o nível de detalhes dos registros (depuração, informações, aviso, erro)
- **Localização do Arquivo de Registro**: Caminho para os arquivos de registro
- **Tamanho Máximo do Arquivo de Registro**: Tamanho máximo dos arquivos de registro em MB
- **Manter Arquivos de Registro Por**: Por quanto tempo manter os arquivos de registro

### Depuração
- **Habilitar Modo de Depuração**: Habilitar modo de depuração para resolução de problemas
- **Mostrar Informações de Depuração**: Exibir informações de depuração na interface
- **Gerar Relatórios de Depuração**: Criar relatórios de depuração para suporte

## Redefinindo as Configurações

### Redefinir para Padrões
1. Vá para `Configurações > Avançado > Redefinir Configurações`
2. Clique em **Redefinir para Padrões**
3. Confirme a redefinição no diálogo
4. O aplicativo reiniciará com as configurações padrão

### Redefinir Configurações Específicas
1. Vá para a categoria de configurações que deseja redefinir
2. Clique no botão **Redefinir para Padrões** na parte inferior da página
3. Confirme a redefinição no diálogo
4. Clique em **Salvar** para aplicar as alterações

## Importando/Exportando Configurações

### Exportar Configurações
1. Vá para `Configurações > Avançado > Importar/Exportar Configurações`
2. Clique em **Exportar Configurações**
3. Escolha um local para salvar o arquivo de configurações
4. Clique em **Salvar** para exportar as configurações

### Importar Configurações
1. Vá para `Configurações > Avançado > Importar/Exportar Configurações`
2. Clique em **Importar Configurações**
3. Selecione o arquivo de configurações do seu sistema de arquivos
4. Clique em **Abrir** para importar as configurações
5. Reinicie o aplicativo para aplicar as configurações importadas

## Melhores Práticas para Configurações

1. **Comece com os Padrões**: Comece com as configurações padrão e ajuste conforme necessário
2. **Fazer Backup das Configurações**: Exporte suas configurações após fazer alterações significativas
3. **Testar Alterações**: Teste as alterações nas configurações antes de confiar nelas
4. **Reiniciar Quando Solicitado**: Sempre reinicie o aplicativo quando solicitado para alterações nas configurações
5. **Documentar Configurações Personalizadas**: Mantenha um registro das configurações personalizadas que você fez
6. **Usar Presets**: Salve configurações frequentemente usadas como presets
7. **Otimizar o Desempenho**: Ajuste as configurações de desempenho com base no seu sistema
8. **Redefinir se Ocorrerem Problemas**: Se você encontrar problemas, tente redefinir para as configurações padrão

## Resolução de Problemas com as Configurações

### Configurações Não Estão Salvando
- **Verificar Permissões**: Certifique-se de ter permissão de gravação no local do arquivo de configurações
- **Verificar Espaço em Disco**: Certifique-se de haver espaço suficiente em disco para as configurações
- **Fechar Outras Instâncias**: Certifique-se de que nenhuma outra instância do aplicativo está em execução
- **Redefinir Configurações**: Tente redefinir as configurações para o padrão

### Aplicativo Não Está Iniciando Após a Alterações nas Configurações
- **Redefinir Configurações Manualmente**: Exclua o arquivo de configurações para redefinir para os padrões
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Reinstalar o Aplicativo**: Se a redefinição manual não funcionar, reinstale o aplicativo

### Problemas de Desempenho
- **Ajustar Configurações de Cache**: Aumentar o tamanho do cache para melhor desempenho
- **Reduzir Processamento Paralelo**: Diminuir o número de processos paralelos
- **Desabilitar Animações**: Desligar animações para desempenho mais rápido
- **Habilitar Carregamento Preguiçoso**: Habilitar carregamento preguiçoso para reduzir o tempo de carregamento inicial

## Próximos Passos

- Aprenda sobre [Atalhos do Teclado](./keyboard-shortcuts.md) para acesso rápido a comandos comuns
- Leia sobre [Resolução de Problemas](./troubleshooting.md) para obter ajuda com problemas comuns
- Explore [Perguntas Frequentes](./faq.md) para respostas a perguntas frequentes