import Foundation
import Glibc

/********************************Classes e variaveis**********************************/
class Pokemon {

var national_number : Int // nationaL_number = id
var name : String
//var image : String
var type : String
var hp : Int
var atack : Int
var defense : Int
var level : Int
var exp : Int

//EXP -> ExpParaSubirDeNivel = Nivel * 10
//ExpGanhaPorCombate = Nivel(pokemon derrotado) * 5

init(national_number : Int , name : String , type: String , hp : Int , atack
: Int , defense : Int , level : Int , exp : Int) {
self.national_number = national_number
self.name = name
self.type = type
self.hp = hp
self.atack = atack
self.defense = defense
self.level = level
self.exp = exp
}
}

class PokemonMoves {
  
  var national_number : Int
  var move1 : String
  var move2 : String
  var move3 : String
  var move4 : String

  init(national_number:Int , move1:String , move2:String , move3:String , move4:String){

    self.national_number = national_number
    self.move1 = move1
    self.move2 = move2
    self.move3 = move3
    self.move4 = move4
  }
}

/*******************************************************************************
Sempre que um pokemon evolui temos que lhe atribuir um novo national_number

*******************************************************************************/

class Evolution {

  var national_number : Int // nationaL_number = id
  var new_national_number : Int
  var evolution_name : String
  var new_type : String
  //  hp attaque defesa para somar ao ataque do pokemon
  var hp : Int
  var atack : Int
  var defense : Int
  var level : Int 

  init(national_number : Int, new_national_number : Int , evolution_name :
  String , new_type : String, hp : Int , atack
  : Int , defense : Int , level : Int 
  ){
    self.national_number = national_number
    self.new_national_number = new_national_number
    self.evolution_name = evolution_name
    self.new_type = new_type
    self.hp = hp
    self.atack = atack
    self.defense = defense
    self.level = level 
  }
}

class Moves {

var name : String
var type : String
var base_power : Int

init(name : String , type : String , base_power : Int){

self.name = name
self.type = type
self.base_power = base_power
}
}

/*******************************************************************************
Esta classe contêm os dados de um certo tipo, exemplo tipo erva bate * 2 em
agua e resiste * 2 a fogo, um pokemon não é forte contra ou fraco contra x
pokemon o tipo dele é que define as suas fraquezas e resistências.
Um pokemon de erva vai sempre levar dano * 2 de um pokemon de fogo. Um
pokemon de fogo vai sempre levar dano / 2 num pokemon de erva.
*******************************************************************************/

class Weakneass{

  var type : String
  var resistance : String
  var weakneass : String

  init(type : String , resistance : String , weakneass : String){

    self.type = type
    self.resistance = resistance
    self.weakneass = weakneass
  }
}

var Charmander = Pokemon(
national_number:0,
name:"Charmander",
type:"fogo",
hp:35,
atack:12,
defense:10,
level:5,
exp:0)

var Squirtle = Pokemon( 
national_number:1,
name:"Squirtle",
type:"agua",
hp:35,
atack:12,
defense:10,
level:5,
exp:0)

var Wartortle = Evolution (
national_number:2,
new_national_number:20 ,
evolution_name:"Wartortle",
new_type:"agua",
hp:25,
atack:15,
defense:10,
level:12
)

var Raichu = Evolution (
national_number:2,
new_national_number:20 ,
evolution_name:"Raichu",
new_type:"trovao",
hp:25,
atack:15,
defense:10,
level:16)

var Pikachu = Pokemon(
national_number:2,
name:"Pikchu",
type:"trovao",
hp:85,
atack:62,
defense:30,
level:2,
exp:0)

//Nivel médio
var Garchomp = Pokemon(
national_number:3,
name:"Garchomp",
type:"eletrico",
hp:100,
atack:92,
defense:100,
level:40,
exp:0)

//Nivel fácil
var Ratata = Pokemon(
national_number:4,
name:"Ratata",
type:"Normal",
hp:40,
atack:22,
defense:18,
level:15,
exp:0)

//Nível dificil
var Rayquaza = Pokemon(
national_number:5,
name:"Rayquaza",
type:"fogo",
hp:250,
atack:192,
defense:120,
level:85,
exp:0)

var PokemonIn = Pokemon(
national_number:0,
name:"aaa",
type:"aa",
hp:1,
atack:1,
defense:1,
level:1,
exp:1)

var PokemonInInimigo = Pokemon(
national_number:0,
name:"aaaaa",
type:"aaaa",
hp:1,
atack:1,
defense:1,
level:1,
exp:1)

/*Moves de fogo*/
var ember = Moves(
    name:"ember",
    type:"fogo",
    base_power:40
)

var blastBurn = Moves(
    name:"blast burn",
    type:"fogo",
    base_power:120
)

var overheat = Moves(
    name:"overheat",
    type:"fogo",
    base_power:150
)

/*Moves eletricos*/
var relampago = Moves(
    name:"relampago",
    type:"eletrico",
    base_power:50
)

var relampagoSupremo = Moves(
    name:"relampago supremo",
    type:"eletrico",
    base_power:250
)

var relampagoDeus = Moves(
    name:"relampago do deus",
    type:"eletrico",
    base_power:500
)

/* Moves normais*/
var superSoco = Moves(
    name:"super soco",
    type:"normal",
    base_power:100
)

var cortar = Moves(
    name:"cortar",
    type:"normal",
    base_power:60
)

var agarrar = Moves(
    name:"agarrar",
    type:"normal",
    base_power:80
)

var voar = Moves(
    name:"voar",
    type:"normal",
    base_power:120
)
/* Moves agua*/

var waterGun = Moves(
    name:"pistola de agua",
    type:"agua",
    base_power:80
)

var waterCanon = Moves(
    name:"canhao de agua",
    type:"agua",
    base_power:120
)

var waterCanonX = Moves(
    name:"canhao de agua x",
    type:"agua",
    base_power:180
)

/* Moves Pokemons Teste*/
var charmanderMove = PokemonMoves(
    national_number:0,           
    move1:"ember",
    move2:"super soco",
    move3:"blast burn",
    move4:"relampago supremo"
)

var squirtleMove = PokemonMoves(
    national_number:1,
    move1:"canhao de agua",
    move2:"cortar",
    move3:"pistola de agua",
    move4:"canhao de agua x"
)

var pikachuMove = PokemonMoves(
    national_number:2,
    move1:"relampago",
    move2:"super soco",
    move3:"relampago do deus",
    move4:"relampago supremo"
)

/* Variaveis globais */
var national_number_increment = 5
var pokemon_list = [Charmander,Squirtle,Pikachu,Garchomp,Ratata,Rayquaza]
var moves_list = [ember,blastBurn,overheat,relampago,relampagoDeus,relampagoSupremo,superSoco,cortar,waterGun,waterCanon,waterCanonX,agarrar,voar]
var moves_pokemon = [PokemonMoves]()
var equipa = [Pokemon]()
var evolution_list = [Raichu,Wartortle]
var equipa2 = [Pokemon]()
/***********************************Funções Menu**************************************/

func menuPrincipal(){

  var i : Int
  
  repeat{
    print("\n_________________________________")
    print("\nMenu")
    print("\n0-Sair")
    print("\n1-Menu Admin")
    print("\n2-Simular Batalhas\n")
    print("Escolha uma opção ->\n")
    
    i = Int(readLine()!)!

    print("\n_________________________________")

    switch i { 
    case 0:
      print("\nObrigado até a proxima")
    case 1:
        menuAdmin()
    case 2:
        menuBatalha()
    default:
        print("\nNada Selecionado")
    }

  }while i > 0

}

func menuAdmin(){

  var i : Int
  
  repeat{
    print("\n_________________________________")
    print("\nMenu Admin")
    print("\n0-Voltar")
    print("\n1-Inserir Pokemon")
    print("\n2-Mostrar Pokemon")
    print("\n3-Editar Pokemon")
    print("\n4-Apagar Pokemon")
    print("\n5-Inserir Moves")
    print("\n6-Mostrar Moves\n")
    print("Escolha uma opção ->\n")
    
    i = Int(readLine()!)!

    print("\n_________________________________")

    switch i { 
    case 0:
      print("\nBem vindo ao Menu Admin")
    case 1:
        inserirPokemon()
    case 2:
        mostrarPokemon()
    case 3:
        editarPokemon()
    case 4:
        apagarPokemon()
    case 5:
        inserirMoves()
    case 6:
        mostrarMoves()
    default:
        print("\nNada Selecionado")
    }

  }while i > 0

}

func menuBatalha(){

  var i : Int
  
  repeat{
    print("\n_________________________________")
    print("\nMenu Batalhas")
    print("\n0-Voltar")
    print("\n1-Escolher Equipa")
    print("\n2-Ver Equipa")
    print("\n3-Combate vs PC")
    print("\n4- Pokecentro(Manutenção)\n")
    print("Escolha uma opção ->\n")
    
    i = Int(readLine()!)!

    print("\n_________________________________")

    switch i { 
    case 0:
      print("\nBem vindo ao Menu Batalha")
    case 1:
        selecionarPokemon()
    case 2:
          mostrarEquipa()
    case 3:
          campoBatalha()
    case 4:
          //pokecentro()
          break;
    default:
        print("\nNada Selecionado")
    }

  }while i > 0

}
/***********************************Funções Admin*************************************/
func inserirPokemon(){

print("Nome do Pokemon->\n")
let name = readLine()
print("Tipo do Pokemon->\n")
let type = readLine()
print("Hp do Pokemon->\n")
let hp = Int(readLine()!)! 
print("Ataque do Pokemon->\n")
let atack = Int(readLine()!)! 
print("Defesa do Pokemon->\n")
let defense = Int(readLine()!)! 
print("Nível do Pokemon->\n")
let level = Int(readLine()!)! 

let pokemon = Pokemon(
national_number:national_number_increment,
name:name!,
type:type!,
hp:hp,
atack : atack,
defense : defense,
level : level,
exp : 0)

pokemon_list.append(pokemon)

national_number_increment = national_number_increment + 1

print("Pokemon inserido com sucesso")

}

func mostrarPokemon(){
  
  for pokemon_list in pokemon_list {
    print("Detalhes dos Pokemons\n",  
          "Numero da pokedex->",pokemon_list.national_number,"\n",
          "Nome->",pokemon_list.name,"\n",
          "Tipo->",pokemon_list.type,"\n",
          "Vida->",pokemon_list.hp,"\n",
          "Ataque->",pokemon_list.atack,"\n",
          "Defesa->",pokemon_list.defense,"\n",
          "Nível->",pokemon_list.level,"\n",
          "Experiência->",pokemon_list.exp,"\n")
  }

}

func indexPokemon (id:Int) {
   
    var index = 0

    for pokemon_list in pokemon_list{
      if(id == index){
        print("Detalhes dos Pokemons\n",  
          "Numero da pokedex->",pokemon_list.national_number,"\n",
          "Nome->",pokemon_list.name,"\n",
          "Tipo->",pokemon_list.type,"\n",
          "Vida->",pokemon_list.hp,"\n",
          "Ataque->",pokemon_list.atack,"\n",
          "Defesa->",pokemon_list.defense,"\n",
          "Nível->",pokemon_list.level,"\n",
          "Experiência->",pokemon_list.exp,"\n")
      }  
      index = index + 1
    }
} 

func editarDadosPokemon(id:Int){

var index = 0

print("Nome do Pokemon->\n")
let name = readLine()
print("Tipo do Pokemon->\n")
let type = readLine()
print("Hp do Pokemon->\n")
let hp = Int(readLine()!)! 
print("Ataque do Pokemon->\n")
let atack = Int(readLine()!)! 
print("Defesa do Pokemon->\n")
let defense = Int(readLine()!)! 
print("Nível do Pokemon->\n")
let level = Int(readLine()!)! 

let pokemon = Pokemon(
national_number:national_number_increment,
name:name!,
type:type!,
hp:hp,
atack : atack,
defense : defense,
level : level,
exp : 0)


for pokemon_list in pokemon_list{
      if id == index {
        pokemon_list.name = pokemon.name
        pokemon_list.type = pokemon.type
        pokemon_list.hp = pokemon.hp
        pokemon_list.atack = pokemon.atack
        pokemon_list.defense = pokemon.defense
        pokemon_list.level = pokemon.level
      }  
      index = index + 1
    }

}

func editarPokemon(){

  print("Digite o id do pokemon que quer editar")
  let i = Int(readLine()!)! 

  indexPokemon(id:i)
  editarDadosPokemon(id:i)

  print("Pokemon editado com sucesso")
  
}

func apagarPokemon(){

  print("Digite o id do pokemon que quer apagar")
  let i = Int(readLine()!)! 
  
  pokemon_list.remove(at:i)

  print("Pokemon apagado com sucesso")
}

func inserirMoves(){
     
  print("Nome do move->\n")
  let name = readLine()
  print("Tipo do move->\n")
  let type = readLine()
  print("Poder do move ->\n")
  let power = Int(readLine()!)! 

  let move = Moves(
  name:name!,
  type:type!,
  base_power:power
  )

  moves_list.append(move)

  print("Move inserido com sucesso")

}

func mostrarMoves(){

  print("Moves inseridos\n")
  for moves_list in moves_list {
    print("Nome->",moves_list.name,"\n",
          "Tipo->",moves_list.type,"\n",
          "Poder do move->",moves_list.base_power,"\n")
  }
} 

/**********************************Funções Batalha************************************/
func combateSelecionarPokemon(){
  
  var controlerPokemon = 0 
  for equipa in equipa{
    if PokemonIn.national_number == equipa.national_number{
      equipa.hp = PokemonIn.hp}
  }


    print("\nSua equipa")
    for equipa in equipa{
      print("\n HP->",equipa.hp,"|",equipa.name,"| level->",equipa.level)
    }

    
    repeat { 
    print("\nEscolha o seu pokemon ->")
    let y = readLine()
    for equipa in equipa{
      if equipa.name == y {
    
        PokemonIn.national_number = equipa.national_number
        PokemonIn.hp = equipa.hp
        PokemonIn.name = equipa.name
        PokemonIn.atack = equipa.atack
        PokemonIn.defense = equipa.defense
        PokemonIn.type = equipa.type
        PokemonIn.level = equipa.level
        PokemonIn.exp = equipa.exp
        
        controlerPokemon = 1
      }
    }

  }while(controlerPokemon == 0)

      print("\n\n", 
      PokemonInInimigo.hp,PokemonInInimigo.name,
      "\n_________________________________\n\n",
      PokemonIn.hp,PokemonIn.name,
      "\n\n")
}

func selecionarPokemonInimigo(min:Int, max:Int){
  
  var controlerPokemon = 0 

  repeat{
    let number = Int.random(in:0...national_number_increment)
    //print(number)
    for pokemon_list in pokemon_list{
      if pokemon_list.national_number == number {
        if pokemon_list.level < max && pokemon_list.level > min {
          PokemonInInimigo.national_number = pokemon_list.national_number
          PokemonInInimigo.hp = pokemon_list.hp
          PokemonInInimigo.name = pokemon_list.name
          PokemonInInimigo.atack = pokemon_list.atack
          PokemonInInimigo.defense = pokemon_list.defense
          PokemonInInimigo.type = pokemon_list.type
          PokemonInInimigo.level = pokemon_list.level
          PokemonInInimigo.exp = pokemon_list.exp

          controlerPokemon = 1
        }
      }
    }
  }while(controlerPokemon == 0)
}
func escolherDificuldade(){

   var controler = 0
  
    repeat{
    print("Escolha o nível de dificuldade->")
    print("fácil | médio | Díficil")
    let y = readLine()
      if y == "fácil" {
        selecionarPokemonInimigo(min:0,max:40)
        controler = 1
      }

      else if y == "médio"{
        selecionarPokemonInimigo(min:40,max:80)
        controler = 1
      }

      else if y == "Díficil"{
        selecionarPokemonInimigo(min:80,max:120)
        controler = 1
      }
      else{
        print("\nEscolha uma opção válida")
      }
    }while(controler == 0)

}

func pokmeonInimigoMoves(){

    let size = moves_list.count
    var validate = 0
    var n_moves = 0
    var nome:String?
    var move1:String?
    var move2:String?
    var move3:String?
    var move4:String?

      repeat {
      
      let moves = Int.random(in:0...size)
      var randomId = 0

      for moves_list in moves_list{
        if moves == randomId{
          if moves_list.type == PokemonInInimigo.type || moves_list.type == "Normal" || moves_list.type == "normal" {
            nome = moves_list.name
            validate = 1
          }
        }
        randomId = randomId + 1
      }
      if validate == 1 {
    
      switch n_moves {
        case 0:  
          move1 = nome
          validate = 0
          n_moves = n_moves + 1
        case 1:
          if move1 != nome{
            move2 = nome
            validate = 0
            n_moves = n_moves + 1
          }
        case 2:
          if move2 != nome && move1 != nome{
            move3 = nome
            validate = 0
            n_moves = n_moves + 1
          }
        case 3:
         if move3 != nome && move2 != nome && move1 != nome {
            move4 = nome
            validate = 0
            n_moves = n_moves + 1
          }
        default:
        print("Inválido")
        }
      }
    }while(n_moves <= 3)

    let movePokemon = PokemonMoves(
      national_number:PokemonInInimigo.national_number,
      move1:move1!,
      move2:move2!,
      move3:move3!,
      move4:move4!
      )

    moves_pokemon.append(movePokemon)

}

func campoBatalha(){
  
  escolherDificuldade()
  pokmeonInimigoMoves()
  var x = PokemonInInimigo.hp
  combateSelecionarPokemon()
  print( "\n_________________________________\n",
        "_________________________________\n")
    repeat{
    print("\n\n", 
        x,PokemonInInimigo.name,
        "\n_________________________________\n\n",
        PokemonIn.hp,PokemonIn.name,
        "\n\n")

           for moves_pokemon in moves_pokemon{
             
             if moves_pokemon.national_number == PokemonIn.national_number{
                print("\n__Escreva o move que o pokemon deve usar__\n",
                     "\n",moves_pokemon.move1,
                    " ",moves_pokemon.move2,
                    "\n",moves_pokemon.move3,
                    " ",moves_pokemon.move4,"\n",
                    "\nTrocar Pokemon",
                    "|Fugir",
                    "\n->")
                     let i = readLine()
                     if i == "Fugir" {
                       x = -1 
                       print("Conseguiu fugir")
                       break;
                     }
                     else if(i == "Trocar Pokemon"){
                       combateSelecionarPokemon()
                     }
                     else{
                       var ataque = verAtaque(ataque:i!)
                       
                       ataque = (ataque + PokemonIn.atack) - PokemonInInimigo.defense
                       
                       if(ataque > 0){
                          x -= ataque 
                          print(ataque)
                       }
                       else{
                         let number = Int.random(in:1...5)
                         x -= number
                       }

                      if x <= 0 {
                         print("\n\n", 
                          "0",PokemonInInimigo.name,
                          "\n_________________________________\n\n",
                          PokemonIn.hp,PokemonIn.name,
                          "\n\n")
                        verex()
                        break;
                      }     
                     var ataqueInimigo = verAtaqueInimigo()     
                     ataqueInimigo = (ataqueInimigo + PokemonInInimigo.atack ) - PokemonIn.defense  

                      if(ataqueInimigo > 0){
                          PokemonIn.hp -= ataqueInimigo 
                       }
                       else{
                         let number = Int.random(in:1...5)
                         PokemonIn.hp -= number
                       }    
                       if PokemonIn.hp == 0 {
                         print("\n\n", 
                          "0",PokemonIn.name,
                          "\n_________________________________\n\n")

                        combateSelecionarPokemon()
                      }  
                      else if  PokemonIn.hp < 0  {
                         print("\n\n", 
                          "0",PokemonIn.name,
                          "\n_________________________________\n\n")
                        PokemonIn.hp = 0
                        combateSelecionarPokemon()
                      } 
                  }
             }
        }
  }while(x>0)
}

func verex () {

  var ex = PokemonInInimigo.level*5
  print (PokemonIn.exp)
  PokemonIn.exp +=  ex

  repeat{
    ex = PokemonIn.level * 10
    if PokemonIn.exp >= ex {
        PokemonIn.exp -= ex
        PokemonIn.level += 1
        PokemonIn.atack += 5
        PokemonIn.defense += 5
        PokemonIn.hp += 10
        ex = PokemonIn.level * 10
        print ("subir de nivel  ",PokemonIn.level )
    }
  }while (PokemonIn.exp >= ex)

  for equipa in equipa
  {
    if equipa.national_number == PokemonIn.national_number{
      equipa.level = PokemonIn.level
      equipa.hp = PokemonIn.hp
      equipa.defense = PokemonIn.defense
      equipa.atack = PokemonIn.atack
      equipa.exp = PokemonIn.exp
    }     
  }

    for equipa2 in equipa2
    {
      if equipa2.national_number == PokemonIn.national_number{
        equipa2.hp += 10
      }     
    }

}

func verEvolution () {
  for evolution_list in evolution_list {
       if evolution_list.national_number == PokemonIn.national_number  {
         


       }

  }


}

func verAtaqueInimigo() -> Int{

      let randomMoves = Int.random(in:0...3)
      var base_ataque = -0
        for moves_pokemon in moves_pokemon{
          if PokemonInInimigo.national_number ==    moves_pokemon.national_number {
              if  randomMoves == 0 {
                base_ataque = verAtaque(ataque:moves_pokemon.move1)
                return base_ataque
              }
              else if randomMoves == 1 {
                base_ataque = verAtaque(ataque:moves_pokemon.move2)
                return base_ataque
              }
              else if randomMoves == 2 {
                base_ataque = verAtaque(ataque:moves_pokemon.move3)
                return base_ataque
              }

              else if randomMoves == 3 {
                base_ataque = verAtaque(ataque:moves_pokemon.move4)
                return base_ataque
              }
              else{
                base_ataque = Int.random(in:1...5)
                return base_ataque
              }

            }
          }
        return 0
      }

func verAtaque(ataque:String) -> Int{
  
  for moves_list in moves_list{
    if(moves_list.name == ataque){
      return moves_list.base_power
    }  
  }
  return -1
} 

func teste(){
  
  equipa.append(Charmander)
  equipa.append(Squirtle)
  equipa.append(Pikachu)
  moves_pokemon.append(charmanderMove)
  moves_pokemon.append(squirtleMove)
  moves_pokemon.append(pikachuMove)

  equipa2 = equipa
}

func verificarMove(addMove:String) ->Int{

  for moves_list in moves_list{
    if(addMove == moves_list.name){
      return 1
    }
  }
  print("\nMove inválido")

  return 0
} 


func adicionarMove(id:Int){
  
  var n_moves = 0
  var move1:String?
  var move2:String?
  var move3:String?
  var move4:String?

  repeat {
    print("\nNome do ",n_moves+1," move->")
    let nome = readLine()!
    var t = verificarMove(addMove:nome)
    if t == 1{
    switch n_moves {
      case 0:  
        move1 = nome
        n_moves = n_moves + 1
        t = 0
      case 1:
        move2 = nome
        n_moves = n_moves + 1
        t = 0
      case 2:
        move3 = nome
        n_moves = n_moves + 1
        t = 0
      case 3:
        move4 = nome
        n_moves = n_moves + 1
        t = 0
       default:
       print("Inválido")
      }
    }
  }while(n_moves <= 3)

   let movePokemon = PokemonMoves(
    national_number:id,
    move1:move1!,
    move2:move2!,
    move3:move3!,
    move4:move4!
    )

    moves_pokemon.append(movePokemon)

  
}

func selecionarPokemon(){
  var i = 0
  var y = 0
  
  repeat{
    print("\nDigite o id do pokemon que quer inserir na sua equipa")  
    i = Int(readLine()!)! 
    y = y + 1
    for pokemon_list in pokemon_list{
      if(pokemon_list.national_number == i){
        equipa.append(pokemon_list)
        adicionarMove(id:i)
      }  
    }

  } while(y < 3) 

  equipa2 = equipa
  
}

func mostrarEquipa(){
      
      print("Pokemons da sua equipa")
      for equipa in equipa {
      print(
          "Numero da pokedex->", equipa.national_number,"\n",
          "Nome->", equipa.name,"\n",
          "Tipo->",equipa.type,"\n",
          "Vida->",equipa.hp,"\n",
          "Ataque->",equipa.atack,"\n",
          "Defesa->",equipa.defense,"\n",
          equipa.level)            
      
      print("Move do Pokemon",equipa.name)
      for moves_pokemon in moves_pokemon{
        if equipa.national_number == moves_pokemon.national_number{
          print(
                "\n",moves_pokemon.move1,
                "|",moves_pokemon.move2,
                "\n",moves_pokemon.move3,
                "|",moves_pokemon.move4,
                "\n"
          )
        }
      }
  }  
} 

func pokecentro(){
  
  for equipa in equipa{
    for equipa2 in equipa2{
      if equipa.national_number == equipa2.national_number{
        equipa.hp = equipa2.hp
      } 
    }
  }
}

teste() /* Se não quiser inserir pokemons  e moves manualmente descomente a função*/

menuPrincipal()