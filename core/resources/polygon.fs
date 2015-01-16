#ifdef GL_ES
precision mediump float;
#endif

uniform mat4 u_modelView;
uniform mat4 u_modelViewProj;
uniform float u_time;

#pragma tangram: material
#pragma tangram: _fragment_lighting

varying vec4 v_color;
varying vec3 v_eyeToPoint;
varying vec3 v_normal;
varying vec2 v_texcoord;

void main(void) {
	vec4 color = v_color;

    #ifdef TANGRAM_FRAGMENT_LIGHTS
	   calculateLighting(v_eyeToPoint, v_normal, color);
    #endif

  	gl_FragColor = color;
}
