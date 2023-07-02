using CodeBase.Infrastructure.Services;
using UnityEngine;

namespace CodeBase.Services
{
    public interface IInputService : IService
    {
        Vector2 axis { get; }
        bool AttackButtonUp();
    }
}