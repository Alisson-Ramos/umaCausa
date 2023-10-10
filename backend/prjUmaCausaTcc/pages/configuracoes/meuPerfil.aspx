﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meuPerfil.aspx.cs" Inherits="prjUmaCausaTcc.pages.configuracoes.meuPerfil" %>

<!DOCTYPE html>

<html lang="pt-br">

 

<head runat="server">

 

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

 

  <meta charset="UTF-8">

 

  <meta http-equiv="X-UA-Compatible" content="IE=edge">

 

  <meta name="viewport" content="width=device-width, initial-scale=1.0">

 

  <link rel="preconnect" href="https://fonts.googleapis.com">

 

  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>

 

  <link href="https://fonts.googleapis.com/css2?family=Lato:wght@400;700&family=Roboto:wght@900&display=swap" rel="stylesheet">

 

  <link rel="stylesheet" href="./../swiper/swiper-bundle.min.css">

 

  <link rel="stylesheet" href="./../../css/index.css">

 

  <link rel="stylesheet" href="./../../css/meuPerfil.css">

 

  <title>UmaCausa - Meu Perfil</title>

 

</head>

 

<body>

 

    <form id="form1" runat="server">

 

          <header>

 

         <asp:Literal ID="LitHeader" runat="server">

 

           <%-- <nav>

 

              <a href="./../index.html"><img class="logo-header" src="./../images/logo/logoAzul.svg" alt=""></a>

 

              <ul>

 

                <li><a href="./../ongs.aspx">Ongs</a></li>

 

                <li><a href="./../campanhas.aspx">Campanhas</a></li>

 

                <li><a href="./../login.aspx">Login</a></li>

 

                <li><a href="./../cadastro.aspx"><button> <img src="./../../images/icons/user.png" />Cadastre-se</button></a></li>

 

              </ul>

 

            </nav>--%>

 

        </asp:Literal>

 

  </header>

 

 

  <main>

 

      <asp:Literal ID="Litmenu" runat="server">

 

<%--        <nav>

 

          <ul>

 

            <li>

 

              <a href="./meuPerfil.aspx">

 

                <img src="./../../images/icons/userAzul.png" alt="">

 

                Meu Perfil

 

              </a>

 

            </li>

 

            <li>

 

              <a href="./minhasColaboracoes.aspx">

 

                <img src="./../../images/icons/maos.png" alt="">

 

                Minhas Colaborações

 

              </a>

 

            </li>

 

            <li>

 

              <a href="./meusItens.aspx">

 

                <img src="./../../images/icons/caixa.png" alt="">

 

                Meus Itens

 

              </a>

 

            </li>

 

            <li>

 

              <a href="./confirmacoesDoacoes.aspx">

 

                <img src="./../../images/icons/confirmacao.png" alt="">

 

                Confirmações de Doações

 

              </a>

 

            </li>

 

            <li>

 

              <a href="./minhasCampanhas.aspx">

 

                <img src="./../../images/icons/megafone.png" alt="">

 

                Minhas Campanhas

 

              </a>

 

            </li>

 

            <li>

 

              <a href="./alterarSenha.aspx">

 

                <img src="./../../images/icons/cadeado.png" alt="">

 

                Alterar Senha

 

              </a>

 

            </li>

 

          </ul>

 

        </nav>  --%>

 

          </asp:Literal>

 

    <hr>

 

    <div class="infos-configuracoes">

 

      <div class="titulo-info">

 

        <img src="./../../images/icons/userAzul.png" alt="">

 

        Meu Perfil

 

      </div>

 

      <div class="infos">

 

        <div class="input-label">

 

          <label for="">Nome:</label>

 

          <asp:TextBox ID="TxtNome" runat="server" ></asp:TextBox>

 

        </div>

 

        <div class="input-label">

 

          <label for="">CNPJ:</label>

 

            <asp:TextBox ID="TxtCnpj" runat="server" disabled=""></asp:TextBox>

 

        </div>

 

        <div class="input-label">

 

          <label for="">Email:</label>

 

           <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email"></asp:TextBox>

 

        </div>

 

        <div class="input-label">

 

          <label for="">Telefone:</label>

 

          <asp:TextBox ID="TxtTelefone" runat="server" AutoCompleteType="Cellular" maxlength="12"></asp:TextBox>

 

        </div>

 

      </div>

 

 

      <div class="infos">

 

        <div class="input-label" id="cep">

 

          <label for="">CEP:</label>

 

          <asp:TextBox ID="TxtCep" runat="server" TextMode="Number" placeholder="11538105"></asp:TextBox>

 

        </div>

 

        <div class="input-label" id="UF">

 

          <label for="">UF:</label>

 

          <asp:DropDownList ID="txtUF" runat="server">

 

                      <asp:ListItem value="" Text=""/>

 

                      <asp:ListItem value="AC" Text="AC"/>

 

                      <asp:ListItem value="AL" Text="AL"/>

 

                      <asp:ListItem value="AP" Text="AP"/>

 

                      <asp:ListItem value="AM" Text="AM"/>

 

                      <asp:ListItem value="BA" Text="BA"/>

 

                      <asp:ListItem value="CE" Text="CE"/>

 

                      <asp:ListItem value="DF" Text="DF"/>

 

                      <asp:ListItem value="ES" Text="ES"/>

 

                      <asp:ListItem value="GO" Text="GO"/>

 

                      <asp:ListItem value="MA" Text="MA"/>

 

                      <asp:ListItem value="MT" Text="MT"/>

 

                      <asp:ListItem value="MS" Text="MS"/>

 

                      <asp:ListItem value="MG" Text="MG"/>

 

                      <asp:ListItem value="PA" Text="PA"/>

 

                      <asp:ListItem value="PB" Text="PB"/>

 

                      <asp:ListItem value="PR" Text="PR"/>

 

                      <asp:ListItem value="PE" Text="PE"/>

 

                      <asp:ListItem value="PI" Text="PI"/>

 

                      <asp:ListItem value="RJ" Text="RJ"/>

 

                      <asp:ListItem value="RN" Text="RN"/>

 

                      <asp:ListItem value="RS" Text="RS"/>

 

                      <asp:ListItem value="RO" Text="RO"/>

 

                      <asp:ListItem value="RR" Text="RR"/>

 

                      <asp:ListItem value="SC" Text="SC"/>

 

                      <asp:ListItem value="SP" Text="SP"/>

 

                      <asp:ListItem value="SE" Text="SE"/>

 

                      <asp:ListItem value="TO" Text="TO"/>

 

                  </asp:DropDownList>

 

        </div>

 

        <div class="input-label" id="cidade">

 

          <label for="">Cidade:</label>

 

          <asp:TextBox ID="TxtCidade" runat="server"></asp:TextBox>

 

        </div>

 

        <div class="input-label" id="bairro">

 

          <label for="">Bairro:</label>

 

          <asp:TextBox ID="TxtBairro" runat="server" MaxLength="45"></asp:TextBox>

 

        </div>

 

        <div class="input-label" id="logradouro">

 

          <label for="">Logradouro:</label>

 

           <asp:TextBox ID="TxtLogadouro" runat="server"></asp:TextBox>

 

        </div>

 

        <div class="input-label" id="numero">

 

          <label for="">Número:</label>

 

          <asp:TextBox ID="txtNumero" runat="server" TextMode="Number" MaxLength="5"></asp:TextBox>

 

        </div>

 

        <div class="input-label" id="complemento">

 

          <label for="">Complemento:</label>

 

            <asp:TextBox ID="txtComplemento" runat="server" MaxLength="45"></asp:TextBox>

 

        </div>

 

          </div>

 

        <asp:Panel ID="PnlItensOngs" runat="server">

 

          <div class="infos">

 

            <div class="input-label">

 

              <label for="">Pix:</label>

 

              <asp:TextBox ID="TxtPix" runat="server"></asp:TextBox>

 

            </div>

 

            <div class="input-label">

 

              <label for="">WebSite:</label>

 

              <asp:TextBox ID="TxtWebsite" runat="server" TextMode="Url"></asp:TextBox>

 

            </div>

 

            <div>

 

              <div class="input-label" id="categoria">

 

                <label for="">Categoria:</label>

 

                 <asp:DropDownList ID="cmbCategorias" runat="server">

 

                 <asp:ListItem>Selecione uma Categoria</asp:ListItem>

 

                 </asp:DropDownList>

 

              </div>

 

              <div class="input-label" id="itens">

 

                <label for="">Itens Aceitos:</label>

 

                  <asp:DropDownList ID="cmbTipoItem" runat="server">

 

                 <asp:ListItem>Selecione o tipo do item</asp:ListItem>

 

                 </asp:DropDownList>

 

              </div>

 

              <div class="input-label" id="dsOng">

 

                <label for="">Resumo da Ong:</label>

 

                  <asp:TextBox ID="txtDescricao" TextMode="MultiLine" Columns="30" Rows="10" runat="server" MaxLength="1000"></asp:TextBox>

 

 

              </div>

 

            </div>

 

            <div class="input-label" id="logo">

 

              <label for="">Logo da Ong:</label>

 

              <div class="espaco-imagem">

 

                <label class="custom-file-upload">

 

                  <input type="file" id="fileInput" accept="image/*" />

 

                  <span class="textoInputFile">Carregar Foto</span>

 

                </label>

 

                <span id="nomeArquivo">Foto quadrada em JPG</span>

 

              </div>

 

            </div>

 

            <div class="input-label" id="bannerOng">

 

              <label for="">Banner da Ong:</label>

 

              <div class="espaco-imagem">

 

                <label class="custom-file-upload">

 

                  <input type="file" id="fileInput" accept="image/*" />

 

                  <span class="textoInputFile">Carregar Foto</span>

 

                </label>

 

                <span id="nomeArquivo">Imagem Retangular em JPG</span>

 

              </div>

 

            </div>

 

          </asp:Panel>

 

         <asp:Button ID="BtnSalvarAlteraçoes" runat="server" Text="Salvar Alterações" class="button-salvar" OnClick="BtnSalvarAlteraçoes_Click"/>

 

      </div>

 

    </div>

 

 

  </main>

 

 

  <footer>

 

      <asp:Literal ID="LitFooter" runat="server">

 

        <%--<nav>

 

          <a href="./../index.html"><img src="./../../images/logo/logoBranca.png" alt="logo umaCausa" /></a>

 

          <div>

 

            <h3>Inicio</h3>

 

            <p><a href="./../index.html">Home</a></p>

 

            <p><a href="./../campanhas.html">Campanhas</a></p>

 

            <p><a href="./../ongs.html">ONGs</a></p>

 

          </div>

 

          <div>

 

            <h3>Sobre Nós</h3>

 

            <p><a href="./../sobre.html">Sobre</a></p>

 

            <p><a href="./../nossaEquipe.html">Nossa Equipe</a></p>

 

          </div>

 

          <div>

 

            <h3>Suporte</h3>

 

            <p><a href="./../faq.html">FAQ</a></p>

 

          </div>

 

        </nav>--%>

 

    </asp:Literal>

 

  </footer>

 

 

  <script src="./../../js/inputFile.js"></script>

 

  <script src="./../../js/cep.js"></script>

 

    </form>

 

</body>

 

</html>
