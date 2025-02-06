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