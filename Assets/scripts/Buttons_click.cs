using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;








public class Buttons_click : MonoBehaviour
{

    string[] sout_america_list = {
        "Argentina",
        "Bolivia",
        "Brasil",
        "Chile",
        "Colombia",
        "Equador",
        "Ilha Falklands",
        "Ilhas Georgia",
        "Guiana Francesa",
        "Guiana",
        "Paraguai",
        "Peru",
        "Suriname",
        "Uruguai",
        "Venezuela",
    };

    string[] europe_list = {
        "Albânia",
        "Alemanha",
        "Andorra",
        "Arménia",
        "Azerbaijão",
        "Bielorrússia",
        "Bulgária",
        "Bélgica",
        "Bósnia e Herzegovina",
        "Cazaquistão",
        "Chipre",
        "Cidade do Vaticano",
        "Croácia",
        "Dinamarca",
        "Eslováquia",
        "Eslovénia",
        "Espanha",
        "Estónia",
        "Finlândia",
        "França",
        "Geórgia",
        "Gibraltar",
        "Grécia",
        "Guernsey",
        "Hungria",
        "Ilha de Man",
        "Ilhas Faroe",
        "Irlanda",
        "Islândia",
        "Itália",
        "Jersey",
        "Kosovo",
        "Letónia",
        "Liechtenstein",
        "Lituânia",
        "Luxemburgo",
        "Malta",
        "Moldávia",
        "Montenegro",
        "Mónaco",
        "Noruega",
        "Países Baixos",
        "Polônia",
        "Portugal",
        "Reino Unido",
        "República Checa",
        "República da Macedónia",
        "Roménia",
        "Rússia",
        "San Marino",
        "Suécia",
        "Suíça",
        "Svalbard",
        "Sérvia",
        "Turquia",
        "Ucrânia",
        "Áustria",
    };


    string[] Australian_list = {
        "Austrália",
        "Papua-Nova Guiné",
        "Nova Zelândia",
        "Fiji",
        "Ilhas Salomão",
        "Polinésia Francesa",
        "Nova Caledônia",
        "Vanuatu",
        "Samoa",
        "Guam",
        "Micronésia",
        "Tonga",
        "Kiribati",
        "Marianas Setentrionais",
        "Samoa Americana",
        "Ilhas Marshall",
        "Palau",
        "Ilhas Cook",
        "Wallis e Futuna",
        "Tuvalu",
        "Nauru",
        "Ilha Norfolk",
        "Niue",
        "Toquelau",
        "Pitcairn",
    };

    string[] North_America_list = {
        "Bermudas",
        "Canadá",
        "Estados Unidos",
        "Groenlândia",
        "México",
        "São Pedro e Miquelão",
    };



    string[] Africa_list = {
        "África do Sul",
        "Angola",
        "Argélia",
        "Benim",
        "Botswana",
        "Burkina Faso",
        "Burundi",
        "Cabo Verde",
        "Camarões",
        "Chade",
        "Comores",
        "Costa do Marfim",
        "Djibouti",
        "Egito",
        "Eritreia",
        "Etiópia",
        "Gabão",
        "Gana",
        "Guiné",
        "Guiné Equatorial",
        "Guiné-Bissau",
        "Gâmbia",
        "Lesoto",
        "Libéria",
        "Líbia",
        "Madagáscar",
        "Malawi",
        "Mali",
        "Marrocos",
        "Mauritânia",
        "Maurícia",
        "Moçambique",
        "Namíbia",
        "Nigéria",
        "Níger",
        "Quénia",
        "República Centro-Africana",
        "República Democrática do Congo",
        "República do Congo",
        "Ruanda",
        "Senegal",
        "Serra Leoa",
        "Seychelles",
        "Somália",
        "Suazilândia",
        "Sudão",
        "Sudão do Sul",
        "São Tomé e Príncipe",
        "Tanzânia",
        "Togo",
        "Tunísia",
        "Uganda",
        "Zâmbia",
        "Zimbabwe",
        "Canárias",
        "Ceuta",
        "Madeira",
        "Mayotte",
        "Melilla",
        "Reunião",
        "Santa Helena",
        "Somalilândia",
        "República Árabe Saariana Democrática",
    };

    string[] asia_list = {
        "Afeganistão",
        "Arábia Saudita",
        "Armênia",
        "Azerbaijão",
        "Bahrein", 
        "Bangladesh",
        "Brunei", 
        "Butão", 
        "Camboja", 
        "Cazaquistão", 
        "Catar",
        "China", 
        "Chipre",
        "Cingapura",
        "Coreia do Norte", 
        "Coreia do Sul",
        "Egito",
        "Emirados Árabes", 
        "Filipinas", 
        "Geórgia",
        "Iêmen",
        "Índia",
        "Indonésia",
        "Irã", 
        "Iraque", 
        "Israel",
        "Japão", 
        "Jordâni",
        "Kuwait", 
        "Laos", 
        "Líbano",
        "Malásia", 
        "Maldivas",
        "Mianmar",
        "Mongólia",
        "Nepal",
        "Omã",
        "Paquistão",
        "Quirguistão",
        "Rússia",
        "Síria",
        "Sri Lanka", 
        "Tajiquistão",
        "Tailândia",
        "Timor-Leste",
        "Turcomenistão",
        "Turquia",
        "Uzbequistão",
        "Vietnã",
    };

    string[] continentes_ = {
        "Asian",
        "Europe",
        "North_American",
        "South_American",
        "Australian",
        "Africa"
    };

    private string country;
    string selected = null;
    public GameObject[] Button_typs;
    public GameObject Text_pais;
    public GameObject Text_ponctuations;
    public UnityEngine.UI.Outline Out_btnn;
    private string[] table_selected;
    public int acertos = 0;
    private int max_ponctuation = 10;
    string Continente_rand_select;

    private void getcountry(){
        
        int Continente_rand = Random.Range(0,5);

        switch (Continente_rand)
        {
            case 0:
                Continente_rand_select = sout_america_list[Random.Range(0,14)];
            break;

            case 1:
                Continente_rand_select = europe_list[Random.Range(0,56)];
            break;

            case 2:
                Continente_rand_select = Australian_list[Random.Range(0,24)];
            break;

            case 3:
                int rand_a = Random.Range(1,2);
                if (rand_a == 1){
                    Continente_rand_select = North_America_list[Random.Range(0,5)];
                }else{
                    getcountry();
                }
                
            break;

            case 4:
                Continente_rand_select = Africa_list[Random.Range(0,62)];
            break;

            case 5:
                Continente_rand_select = asia_list[Random.Range(0,48)]; 
            break;

        }
        
        country = Continente_rand_select;

    }

    private void Start() {
        Text_pais = GameObject.Find("Pais");
        Text_ponctuations = GameObject.Find("Ponctuation");
        getcountry();
        
    }

    private void Update() {

       /*  Out_btn.Effect.Distance = distance_x; */

        foreach (var item in Button_typs)
        {
                Out_btnn = item.GetComponentInChildren<UnityEngine.UI.Outline>();

            

                if (Out_btnn.enabled == false && item.name == (selected + "_button")){
                Out_btnn.enabled = true;
                }

                if (Out_btnn.enabled == true && item.name != (selected + "_button")){
                    Out_btnn.enabled = false;
                }
        }

        (Text_pais.GetComponentInChildren<TMPro.TextMeshProUGUI>()).text = country;
        (Text_ponctuations.GetComponentInChildren<TMPro.TextMeshProUGUI>()).text = (acertos.ToString()) + "/" + (max_ponctuation.ToString());
        
       
    }

    
    


    public void Button_Africa_buttonOnClick(){
        selected = "Africa";
        /* Out_btnn = GameObject.Find("Asian_button").GetComponentInChildren<UnityEngine.UI.Outline>().enabled = true; */
    }

    public void Button_South_America_buttonOnClick(){
        selected = "South_American";
    }

    public void Button_North_America_buttonOnClick(){
        selected = "North_American";
    }

    public void Button_Europe_buttonOnClick(){
        selected = "Europe";
    }

    public void Button_Australian_buttonOnClick(){
        selected = "Australian";
    }

    public void Button_Asian_buttonOnClick(){
        selected = "Asian";
    }

    public void Button_Finish_buttonOnClick(){
        int acertou = 0;
        if (selected != null){
            

            switch (selected)
            {
                case "South_American":
                    table_selected = sout_america_list;
                    break;
                case "North_American":
                    table_selected = North_America_list;
                    break;
                case "Africa":
                    table_selected = Africa_list;
                    break;
                case "Europe":
                    table_selected = europe_list;
                    break;
                case "Australian":
                    table_selected = Australian_list;
                    break;
                case "Asian":
                    table_selected = asia_list;
                    break;
            }
            foreach (var item in table_selected)
            {

                if (item == Continente_rand_select){
                    acertos++;
                    acertou = 1;
                    break;
                }
            }
            
            if (acertou == 0){
                acertos--;
                if (acertos < 1){
                    acertos = 0;
                }
                
            }
            getcountry();
        }
        
        if (acertos >= max_ponctuation){
            Debug.Log("voce ganhou");
        }
    }
    
};
