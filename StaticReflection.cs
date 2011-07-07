using System;
using System.Linq.Expressions;

namespace Ekra14.AltFXtension
{
    public static class StaticReflection
    {
        #region Public Methods

        public static string GetMemberName<TEntity, TMember>(this TEntity entity, Expression<Func<TEntity, TMember>> expression)
        {
            return GetMemberName(expression);
        }

        public static string GetMemberName<TEntity, TMember>(Expression<Func<TEntity, TMember>> expression)
        {
            return GetMemberExpression(expression).Member.Name;
        }

        public static string GetMemberName<TEntity>(Expression<Func<TEntity, object>> expression)
        {
            return GetMemberName<TEntity, object>(expression);
        }

        #endregion

        #region Private Methods

        private static MemberExpression GetMemberExpression<TEntity, TMember>(Expression<Func<TEntity, TMember>> expression)
        {
            MemberExpression memberExpression = null;
            switch (expression.Body.NodeType)
            {
                case ExpressionType.Convert:
                    var body = (UnaryExpression)expression.Body;
                    memberExpression = body.Operand as MemberExpression;
                    break;
                case ExpressionType.MemberAccess:
                    memberExpression = expression.Body as MemberExpression;
                    break;
            }
            if (memberExpression == null)
            {
                throw new ArgumentException("Not a member access", "expression");
            }
            return memberExpression;
        }

        #endregion
    }
}