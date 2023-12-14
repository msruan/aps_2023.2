#!/bin/bash

# Adapte os valores apropriados conforme necessário
DB_CONTEXT="MyDbContext"
RELATIVE_FOLDER_PATH="Controllers"

# Lista de classes do modelo
MODELS=("Marca" "Cliente" "Produto" "NotaDeVenda" "Item" "Transportadora" "Pagamento" "PagamentoComCartao" "PagamentoComCheque" "TipoDePagamento" "Vendedor")

# Loop para gerar controladores para cada classe do modelo
for MODEL in "${MODELS[@]}"
do
  CONTROLLER_NAME="${MODEL}sController"

  # Comando para gerar o controlador
  dotnet aspnet-codegenerator controller -name $CONTROLLER_NAME -m $MODEL -dc $DB_CONTEXT --relativeFolderPath $RELATIVE_FOLDER_PATH --useDefaultLayout --referenceScriptLibraries 
done
