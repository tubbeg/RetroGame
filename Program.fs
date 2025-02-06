open Browser
open Fable.Core

(*

Inspired by old-school retro games. Attempting my own retro-looking game.

Self-imposed limitations: 
- 16 colors
- pixel sprites/tiles, preferably < 64px
- audio, preferably 4 channels. Depends on available tools
- Keep it tiny, keep it simple
- Start without entity component system (for now)
- Platformer

*)
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

let div = document.createElement "div"
div.innerHTML <- "Stuff here!"
document.body.appendChild div |> ignore

let createGame () =
    let pl t = ()
    let cr t = ()
    let upd t time delta = ()
        //console.log time
    let s = new Scene(None, pl, cr, upd)
    let conf = createConf s 800 600
    new Game(conf)

createGame () |> ignore