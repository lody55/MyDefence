using UnityEngine;
namespace Solid
{
    // 앞, 뒤로 가는 기능 정의
    public interface IMoveable
    {
        public void GoFoward();
        public void GoBack();
    }
}