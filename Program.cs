using System;
namespace HomeWorkArh1
{
    class Scene
    {
        public int Id;
        public PoligonalModel Models;
        public Flash Flashes;

        public Type method1(Type);
        public Type method2(Type, Type);
    }

    interface IModelChangeObserver
    {
        public ApplyUpdateModel();
    }

    interface IModelChanger
    {
        public NotifyChange(IModelChanger sender);
    }

    class ModelStore : IModelChanger
    {
        public PoligonalModel Models;
        public Scene Scenes;
        public Flash Flashes;
        public Camera Cameras;
        private IModelChangeObserver changeObservers;

        public Scene GetScena(Int);
        public NotifyChange(IModelChanger);
    }

    class PoligonalModel
    {
        public Poligon Poligons;
        public Texture Textures;
    }

    class Texture
    {

    }

    class Poligon
    {
        public Point3D Points;
    }

    class Flash
    {
        public Point3D Location;
        public Angle3D Angle;
        public Color Color;
        public float Power;

        public void Rotate(Angle3D);
        public void Move(Point3D);
    }

    class Camera
    {
        public Point3D Location;
        public Angle3D Angle;

        public void Rotate(Angle3D);
        public void Move(Point3D);
    }

    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}