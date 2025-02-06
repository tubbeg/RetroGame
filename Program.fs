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
    loadImage this "sky" "sky.png"
    ()

let createGame this =
    let img = addImage this 400 400 "sky"
    setGOScale img 3
    ()

let launchGame () =
    let pl this  = ()
    let cr this = ()
    let upd this time delta = ()
        //console.log time
    let s = new Scene(None, loadGame, createGame, upd)
    let conf = createConf s 800 600
    new Game(conf)

launchGame () |> ignore