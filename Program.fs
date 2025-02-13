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


let loadGame scene =
    loadImage scene "player" "player.png"
    loadImage scene "sky" "moonsky.png"
    loadImage scene "bricks" "bricksinsky2.png"
    loadImage scene "cloud" "darkclouds.png"
    loadImage scene "tower" "darktower.png"
    loadTileMapCsv scene "mymap" "brickssky.csv"
    ()

let levelLocation = 0,0

let addTiles scene =
    //this.make.tilemap({ data: level, tileWidth: 16, tileHeight: 16 });
    let tilemap = {|key="mymap"; tileWidth=16;tileHeight=16|} |> makeTileMap scene
    let tiles = addTileSetImage tilemap "bricks"
    let x,y = levelLocation
    //you can add multiple tileset by by passing them as an array when you create the layer
    //i'm guessing that you could possibly "extend" the level by adding another layer, for
    //instance when the player sprite reaches a certain position. Not sure what the easiest
    //is
    let layer = tilemapCreateLayer tilemap 0 tiles x y
    scaleLayer tilemap 2
    
    //collision is not working. Not sure what the problem is

    //setCollideExclude layer [||]
    
    layer


let createGame scene =
    let img = addImage scene 400 400 "sky"
    setGOScale img 3
    let cloud = addSprite scene 400 200 "cloud"
    let tower = addSprite scene 400 400 "tower"
    setGOScale cloud 2
    setGOScale  tower 3
    let l = addTiles scene
    let ps = addPhysicsSprite scene 400 100 "player"
    addCollider scene l ps
    ()

let launchGame () =
    let upd this time delta = ()
        //console.log time
    let s = new Scene(None, loadGame, createGame, upd)
    let conf = createConf s 800 600
    new Game(conf)

launchGame () |> ignore









