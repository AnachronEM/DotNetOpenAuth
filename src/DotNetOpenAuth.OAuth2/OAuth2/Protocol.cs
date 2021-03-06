﻿// <auto-generated/> // disable StyleCop on this file
//-----------------------------------------------------------------------
// <copyright file="Protocol.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// An enumeration of the OAuth protocol versions supported by this library.
	/// </summary>
	public enum ProtocolVersion {
		/// <summary>
		/// The OAuth 2.0 specification.
		/// </summary>
		V20,
	}

	/// <summary>
	/// Protocol constants for OAuth 2.0.
	/// </summary>
	public class Protocol {
		/// <summary>
		/// The HTTP authorization scheme "Bearer";
		/// </summary>
		internal const string BearerHttpAuthorizationScheme = "Bearer";

		/// <summary>
		/// The HTTP authorization scheme "Bearer ";
		/// </summary>
		internal const string BearerHttpAuthorizationSchemeWithTrailingSpace = BearerHttpAuthorizationScheme + " ";

		/// <summary>
		/// The format of the HTTP Authorization header value that authorizes OAuth 2.0 requests using bearer access tokens.
		/// </summary>
		internal const string BearerHttpAuthorizationHeaderFormat = BearerHttpAuthorizationSchemeWithTrailingSpace + "{0}";

		/// <summary>
		/// The name of the parameter whose value is an OAuth 2.0 bearer access token, as it is defined
		/// in a URL-encoded POST entity or URL query string.
		/// </summary>
		internal const string BearerTokenEncodedUrlParameterName = "access_token";

		/// <summary>
		/// The "state" string.
		/// </summary>
		internal const string state = "state";

		/// <summary>
		/// The "redirect_uri_mismatch" string.
		/// </summary>
		internal const string redirect_uri_mismatch = "redirect_uri_mismatch";

		/// <summary>
		/// The "redirect_uri" string.
		/// </summary>
		internal const string redirect_uri = "redirect_uri";

		/// <summary>
		/// The "client_id" string.
		/// </summary>
		internal const string client_id = "client_id";

		/// <summary>
		/// The "scope" string.
		/// </summary>
		internal const string scope = "scope";

		/// <summary>
		/// The "client_secret" string.
		/// </summary>
		internal const string client_secret = "client_secret";

		/// <summary>
		/// The "code" string.
		/// </summary>
		internal const string code = "code";

		/// <summary>
		/// The "error" string.
		/// </summary>
		internal const string error = "error";

		/// <summary>
		/// The "access_token" string.
		/// </summary>
		internal const string access_token = "access_token";

		/// <summary>
		/// The "token_type" string.
		/// </summary>
		internal const string token_type = "token_type";

		/// <summary>
		/// The "refresh_token" string.
		/// </summary>
		internal const string refresh_token = "refresh_token";

		/// <summary>
		/// The "expires_in" string.
		/// </summary>
		internal const string expires_in = "expires_in";

		/// <summary>
		/// The "username" string.
		/// </summary>
		internal const string username = "username";

		/// <summary>
		/// The "password" string.
		/// </summary>
		internal const string password = "password";

		/// <summary>
		/// Gets the <see cref="Protocol"/> instance with values initialized for V1.0 of the protocol.
		/// </summary>
		internal static readonly Protocol V20 = new Protocol {
			Version = new Version(2, 0),
			ProtocolVersion = ProtocolVersion.V20,
		};

		/// <summary>
		/// A list of all supported OAuth versions, in order starting from newest version.
		/// </summary>
		internal static readonly List<Protocol> AllVersions = new List<Protocol>() { V20 };

		/// <summary>
		/// The default (or most recent) supported version of the OpenID protocol.
		/// </summary>
		internal static readonly Protocol Default = AllVersions[0];

		/// <summary>
		/// The "error_uri" string.
		/// </summary>
		internal const string error_uri = "error_uri";

		/// <summary>
		/// The "error_description" string.
		/// </summary>
		internal const string error_description = "error_description";

		/// <summary>
		/// The "response_type" string.
		/// </summary>
		internal const string response_type = "response_type";

		/// <summary>
		/// The "grant_type" string.
		/// </summary>
		internal const string grant_type = "grant_type";

		/// <summary>
		/// Gets or sets the OAuth 2.0 version represented by this instance.
		/// </summary>
		/// <value>The version.</value>
		internal Version Version { get; private set; }

		/// <summary>
		/// Gets or sets the OAuth 2.0 version represented by this instance.
		/// </summary>
		/// <value>The protocol version.</value>
		internal ProtocolVersion ProtocolVersion { get; private set; }

		/// <summary>
		/// Gets the OAuth Protocol instance to use for the given version.
		/// </summary>
		/// <param name="version">The OAuth version to get.</param>
		/// <returns>A matching <see cref="Protocol"/> instance.</returns>
		internal static Protocol Lookup(ProtocolVersion version) {
			switch (version) {
				case ProtocolVersion.V20: return Protocol.V20;
				default: throw new ArgumentOutOfRangeException("version");
			}
		}

		/// <summary>
		/// Error codes that an authorization server can return to a client in response to a malformed or unsupported end user authorization request.
		/// </summary>
		public static class EndUserAuthorizationRequestErrorCodes
		{
			/// <summary>
			/// The request is missing a required parameter, includes an unknown parameter or parameter value, or is otherwise malformed.
			/// </summary>
			public const string InvalidRequest = "invalid_request";

			/// <summary>
			/// The client is not authorized to use the requested response type.
			/// </summary>
			public const string UnauthorizedClient = "unauthorized_client";

			/// <summary>
			/// The end-user or authorization server denied the request.
			/// </summary>
			public const string AccessDenied = "access_denied";

			/// <summary>
			/// The requested response type is not supported by the authorization server.
			/// </summary>
			public const string UnsupportedResponseType = "unsupported_response_type";

			/// <summary>
			/// The requested scope is invalid, unknown, or malformed.
			/// </summary>
			public const string InvalidScope = "invalid_scope";

			/// <summary>
			/// The authorization server encountered an unexpected condition which prevented it from fulfilling the request.
			/// </summary>
			public const string ServerError = "server_error";

			/// <summary>
			/// The authorization server is currently unable to handle the request due to a temporary overloading or maintenance of the server.
			/// </summary>
			public const string TemporarilyUnavailable = "temporarily_unavailable";
		}

		/// <summary>
		/// Values for the "response_type" parameter.
		/// </summary>
		internal static class ResponseTypes
		{
			/// <summary>
			/// The string "code".
			/// </summary>
			internal const string Code = "code";

			/// <summary>
			/// The string "token".
			/// </summary>
			internal const string Token = "token";
		}

		internal static class GrantTypes
		{
			internal const string AuthorizationCode = "authorization_code";

			internal const string Password = "password";

			internal const string Assertion = "assertion";

			internal const string RefreshToken = "refresh_token";

			internal const string ClientCredentials = "client_credentials";
		}

		/// <summary>
		/// Error codes that an authorization server can return to a client in response to a malformed or unsupported access token request.
		/// </summary>
		internal static class AccessTokenRequestErrorCodes
		{
			/// <summary>
			/// The request is missing a required parameter, includes an unknown parameter or parameter value, repeats a parameter,
			/// includes multiple credentials, utilizes more than one mechanism for authenticating the client, or is otherwise malformed.
			/// </summary>
			internal const string InvalidRequest = "invalid_request";

			/// <summary>
			/// Client authentication failed (e.g. unknown client, no client authentication included, or unsupported authentication method).
			/// The authorization server MAY return an HTTP 401 (Unauthorized) status code to indicate which HTTP authentication schemes are supported.
			/// If the client attempted to authenticate via the Authorization request header field, the authorization server MUST respond with
			/// an HTTP 401 (Unauthorized) status code, and include the WWW-Authenticate response header field matching the authentication scheme
			/// used by the client.
			/// </summary>
			internal const string InvalidClient = "invalid_client";

			/// <summary>
			/// The provided authorization grant (e.g. authorization code, resource owner credentials) or refresh token is invalid, expired,
			/// revoked, does not match the redirection URI used in the authorization request, or was issued to another client.
			/// </summary>
			internal const string InvalidGrant = "invalid_grant";

			/// <summary>
			/// The authenticated client is not authorized to use this authorization grant type.
			/// </summary>
			internal const string UnauthorizedClient = "unauthorized_client";

			/// <summary>
			/// The authorization grant type is not supported by the authorization server.
			/// </summary>
			internal const string UnsupportedGrantType = "unsupported_grant_type";

			/// <summary>
			/// The requested scope is invalid, unknown, malformed, or exceeds the scope granted by the resource owner.
			/// </summary>
			internal const string InvalidScope = "invalid_scope";
		}

		/// <summary>
		/// Recognized access token types.
		/// </summary>
		internal static class AccessTokenTypes {
			/// <summary>
			/// The "bearer" token type.
			/// </summary>
			internal const string Bearer = "bearer";
		}

		internal static class BearerTokenUnauthorizedResponseParameters {
			internal const string Realm = "realm";
			internal const string ErrorCode = "error";
			internal const string ErrorDescription = "error_description";
			internal const string ErrorUri = "error_uri";
			internal const string Scope = "scope";
		}

		/// <summary>
		/// The error codes prescribed in http://self-issued.info/docs/draft-ietf-oauth-v2-bearer.html#resource-error-codes
		/// </summary>
		internal static class BearerTokenErrorCodes {
			/// <summary>
			/// The request is missing a required parameter, includes an unsupported parameter or parameter value,
			/// repeats the same parameter, uses more than one method for including an access token, or is otherwise
			/// malformed. The resource server SHOULD respond with the HTTP 400 (Bad Request) status code.
			/// </summary>
			internal const string InvalidRequest = "invalid_request";

			/// <summary>
			/// The access token provided is expired, revoked, malformed, or invalid for other reasons.
			/// The resource SHOULD respond with the HTTP 401 (Unauthorized) status code. The client MAY request
			/// a new access token and retry the protected resource request.
			/// </summary>
			internal const string InvalidToken = "invalid_token";

			/// <summary>
			/// The request requires higher privileges than provided by the access token. The resource server
			/// SHOULD respond with the HTTP 403 (Forbidden) status code and MAY include the scope attribute
			/// with the scope necessary to access the protected resource.
			/// </summary>
			internal const string InsufficientScope = "insufficient_scope";
		}
	}
}
