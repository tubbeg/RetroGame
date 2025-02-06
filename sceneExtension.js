import {AUTO, Scene} from "phaser";



export function createConfig (scenes,w,h){
    const config = {
        type:AUTO,
        scene:scenes,
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