﻿using UnityEngine;

namespace SGUI {
    public class SImage : SElement {

        public Texture Texture;

        public SImage()
            : this(null) { }
        public SImage(Texture texture)
            : this(texture, Color.white) { }
        public SImage(Texture texture, Color color) {
            Texture = texture;
            Foreground = color;
        }

        public override void UpdateStyle() {
            // This will get called again once this element gets added to the root.
            if (Root == null) return;

            if (UpdateBounds && Texture != null) {
                Size = new Vector2(Texture.width, Texture.height);
            }

            base.UpdateStyle();
        }

        public override void Render() {
            RenderBackground();
            Draw.Texture(this, Vector2.zero, Size, Texture, Foreground);
        }

    }
}
