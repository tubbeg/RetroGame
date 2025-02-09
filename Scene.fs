module Scene
open Fable.Core

[<Import("SceneXt","./sceneExtension.js")>]
type Scene (conf, pl : Scene -> unit, cr : Scene -> unit, upd : Scene -> float -> float -> unit) =
    class
    end

[<Import("createConfig","./sceneExtension.js")>]
let createConf (s : Scene) (w : int)  (h : int) : obj = jsNative

[<Import("Game", "phaser")>]
type Game(conf : obj) =
    class
    end


[<Import("loadImage","./sceneExtension.js")>]
let loadImage this id path = jsNative

[<Import("addImage","./sceneExtension.js")>]
let addImage this x y id = jsNative

[<Import("setGOScale","./sceneExtension.js")>]
let setGOScale this scale = jsNative

[<Import("makeTileMap","./sceneExtension.js")>]
let makeTileMap this conf = jsNative

[<Import("addTileSetImage","./sceneExtension.js")>]
let addTileSetImage tilemap id = jsNative

[<Import("tilemapCreateLayer","./sceneExtension.js")>]
let tilemapCreateLayer tilemap i  tiles x y = jsNative

[<Import("myLevel","./sceneExtension.js")>]
let myLevel : array<int> = jsNative

[<Import("scaleLayer","./sceneExtension.js")>]
let scaleLayer tilemap scale = jsNative

[<Import("addSprite","./sceneExtension.js")>]
let addSprite scene x y id = jsNative

[<Import("loadTileMapCsv","./sceneExtension.js")>]
let loadTileMapCsv scene  id path = jsNative