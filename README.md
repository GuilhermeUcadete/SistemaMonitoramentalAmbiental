# 🌍 Sistema de Monitoramento Ambiental via Satélite

## 📌 Motivação do Projeto

O aumento de problemas ambientais como desmatamento, queimadas e garimpo ilegal tem causado impactos significativos no Brasil e no mundo. Muitas dessas atividades acontecem em áreas remotas, dificultando a fiscalização e resposta rápida das autoridades.

Este projeto foi desenvolvido com o objetivo de simular um sistema capaz de trabalhar em conjunto com satélites para:

- Monitorar áreas florestais em tempo real
- Detectar irregularidades ambientais
- Gerar alertas automatizados
- Auxiliar na tomada de decisões

A proposta busca demonstrar como a tecnologia pode ser utilizada para **prevenção e combate a crimes ambientais**, aumentando a eficiência na proteção do meio ambiente.

---

## 🛰️ Como o Sistema Funciona

O sistema simula o funcionamento de um satélite equipado com sensores que coletam diferentes tipos de dados ambientais.

### 🔄 Fluxo do Sistema

1. **Coleta de Dados**
   - Sensores simulam dados como:
     - Imagens (desmatamento)
     - Temperatura (risco de incêndio)
     - Fumaça (queimadas)
     - Atividades suspeitas (garimpo)

2. **Análise dos Dados**
   - Um módulo analisador (com uso de interface) processa os dados coletados
   - Detecta padrões e classifica o tipo de problema

3. **Geração de Alertas**
   - O sistema cria alertas contendo:
     - Descrição do problema
     - Nível de risco (Baixo, Médio, Alto, Crítico)
     - Localização geográfica
     - Data e hora

4. **Identificação da Região**
   - Com base nas coordenadas, o sistema simula a identificação da região afetada
     - Ex: Amazonas, Mato Grosso, São Paulo

5. **Distribuição de Alertas**
   - Dependendo do nível:
     - Alto / Crítico → Autoridades
     - Médio / Baixo → Portais de notícia

---

## ⚙️ Tecnologias e Conceitos Utilizados

O projeto aplica diversos conceitos importantes de programação orientada a objetos:

- ✅ Herança e Polimorfismo (Sensores)
- ✅ Classes Abstratas
- ✅ Interfaces e Injeção de Dependência
- ✅ Tratamento de Exceções
- ✅ Manipulação de DateTime
- ✅ Structs (Coordenadas)
- ✅ Organização em camadas (Models, Services, Interfaces)

---

## 🎯 Tipos de Alertas Detectados

O sistema atualmente identifica:

- 🌳 Desmatamento
- 🔥 Risco de incêndio
- 💨 Queimadas
- ⛏️ Garimpo ilegal

---

## 🚀 Possíveis Expansões Futuras

O sistema foi projetado para ser escalável e pode ser expandido com:

- Integração com APIs reais (INPE, NASA)
- Uso de Inteligência Artificial para previsão
- Interface gráfica (dashboard)
- Monitoramento em tempo real contínuo
- Sistema de relatórios automáticos
