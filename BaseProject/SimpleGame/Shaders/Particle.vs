#version 330

in vec3 a_Position;

uniform float u_Time = 0;

const vec3 c_StartPos = vec3(-1, 0, 0);
const vec3 c_Velocity = vec3(2.0, 0, 0);

void main()
{
	vec4 newPosition;
	newPosition.xyz = (a_Position+c_StartPos) + c_Velocity*u_Time;
	newPosition.w = 1;
	gl_Position = newPosition;
}
