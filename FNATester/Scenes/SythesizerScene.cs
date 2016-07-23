using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
using Nez.TextureAtlases;


namespace FNATester
{
	public class SythesizerScene : Scene
	{
		public override void initialize()
		{
			addRenderer( new DefaultRenderer() );
			clearColor = Color.Black;

			var textureAtlas = content.Load<TextureAtlas>( Content.TextureAtlasTest.atlasImages );
			var tex = textureAtlas.getSubtexture( "background" );

			// create Entities with Sprites
			var tree = createEntity( "sprite" );
			tree.addComponent( new Sprite( tex ) )
			    .addComponent<Sythesizer>()
				.transform.setPosition( Screen.center );
		}
	}
}

