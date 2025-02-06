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