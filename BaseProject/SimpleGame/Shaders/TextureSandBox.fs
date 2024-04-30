#version 330

uniform sampler2D u_Texture;
in vec2 v_TexPos;

layout(location=0) out vec4 FragColor;

uniform vec4 u_Color;

void main()
{

	float tx = v_TexPos.x;
	//float ty = 1-abs(v_TexPos.y*2-1);
	float ty = v_TexPos.y/3;
	vec2 newTexPos = vec2(tx, ty); 
	FragColor = texture(u_Texture, newTexPos);
	//FragColor = vec4(v_TexPos, 0, 1);
}
