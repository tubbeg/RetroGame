open Browser
open Fable.Core
open Scene

(*

Inspired by old-school retro games. Attempting my own retro-looking game.

- As few colors as possible
- pixel sprites/tiles, preferably < 64px
- audio, preferably 4 channels. Depends on available tools
- Keep it tiny, keep it simple
- Start without entity component system (for now)
- Platformer
*)


let loadGame this =
    loadImage this "sky" "moonsky.png"
    loadImage this "bricks" "bricksinsky2.png"
    loadImage this "cloud" "darkclouds.png"
    loadImage this "tower" "darktower.png"
    loadTileMapCsv this "mymap" "brickssky.csv"
    ()

let levelLocation = 0,0

let createGame this =
    let img = addImage this 400 400 "sky"
    setGOScale img 3
    let cloud = addSprite this 400 200 "cloud"
    let tower = addSprite this 400 400 "tower"
    setGOScale cloud 2
    setGOScale  tower 3
    //this.make.tilemap({ data: level, tileWidth: 16, tileHeight: 16 });
    let tilemap = {|key="mymap"; tileWidth=16;tileHeight=16|} |> makeTileMap this
    let tiles = addTileSetImage tilemap "bricks"
    let x,y = levelLocation
    //you can add multiple tileset by by passing them as an array when you create the layer
    //i'm guessing that you could possibly "extend" the level by adding another layer, for
    //instance when the player sprite reaches a certain position. Not sure what the easiest
    //is
    let layer = tilemapCreateLayer tilemap 0 tiles x y
    scaleLayer tilemap 2
    ()

let launchGame () =
    let upd this time delta = ()
        //console.log time
    let s = new Scene(None, loadGame, createGame, upd)
    let conf = createConf s 800 600
    new Game(conf)

launchGame () |> ignore