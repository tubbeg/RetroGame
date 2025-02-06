import {AUTO, Scene} from "phaser";

//js is much better suited at working with npm
//libraries. And F#-JS interop means that I don't
//have to write a ton of bindings. Sometimes F#
//is not good enough. Dynamic languages are better
//sometimes. And that's ok!
export function loadImage(scene, id, path){
    return scene.load.image(id,path);
}

export function addImage(scene, x,y, id){
    return scene.add.image(x,y,id);
}

export function setGOScale(gameObject, scale){
    gameObject.setScale(scale);
}

export function createConfig (scenes,w,h){
    const config = {
        type:AUTO,
        scene:scenes,
        pixelArt: true, //and this is absolutely amazing when working with aseprite!!
        width:w,
        height:h,
        physics : {
            default:"arcade",
            arcade:{
                gravity:{
                    y:200
                }
            }
        }
    }
    return config;
}


export class SceneXt extends Scene {
    constructor(conf,p,c,u){
        super(conf);
        this.p = p;
        this.c = c;
        this.u = u;
    }
    /*It is generally not a good idea to pass the instance
    as a parameter. In this case I'm doing it because it's
    the easiest way to "extend" the class (with composition)
    without writing a million bindings. Just know that this
    is normally taboo*/
    preload(){
        this.p(this);
    }
    create (){
        this.c(this);
    }
    update(time,delta){
        this.u(this,time,delta);
    }
}