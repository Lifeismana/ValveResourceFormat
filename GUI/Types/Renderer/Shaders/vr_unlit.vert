#version 460

#include "common/animation.glsl"

layout (location = 0) in vec3 vPOSITION;
in vec2 vTEXCOORD;

out vec3 vFragPosition;

out vec2 vTexCoordOut;
out vec4 vTintColorFadeOut;

#include "common/ViewConstants.glsl"
uniform mat4 transform;

uniform vec4 g_vTexCoordOffset;
uniform vec4 g_vTexCoordScale;

uniform vec4 vTint;

void main()
{
    vec4 fragPosition = transform * getSkinMatrix() * vec4(vPOSITION, 1.0);
    gl_Position = g_matViewToProjection * fragPosition;
    vFragPosition = fragPosition.xyz / fragPosition.w;

    vTexCoordOut = vTEXCOORD * g_vTexCoordScale.xy + g_vTexCoordOffset.xy;
    vTintColorFadeOut = vTint;
}
